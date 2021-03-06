CREATE OR ALTER PROCEDURE SETPARAMVALUES(PARAMPLACEID SMALLINT, PARAMID INTEGER, DATATYPEID SMALLINT, VAL VARCHAR(2048))
RETURNS (SYSTYPEID SMALLINT)
AS
	DECLARE VARIABLE VALI NUMERIC(18,0);
	DECLARE VARIABLE VALS VARCHAR(2048);
	DECLARE VARIABLE VALB BLOB SUB_TYPE 0 SEGMENT SIZE 80;
	DECLARE VARIABLE FLAG INTEGER;
	DECLARE VARIABLE TMP SMALLINT;
BEGIN
	IF (:PARAMID IS NULL OR :DATATYPEID IS NULL) THEN
		BEGIN
			SYSTYPEID = -1;
			SUSPEND;
			EXIT;
		END

	VALI=NULL;
	VALS=NULL;
	VALB=NULL;
	
	SELECT SYSTYPE FROM DATATYPE WHERE DATATYPEID=:DATATYPEID INTO :SYSTYPEID;
	IF (:SYSTYPEID = 0 OR :SYSTYPEID IS NULL) THEN
		BEGIN
			SYSTYPEID = 0;
			SUSPEND;
			EXIT;
		END
	ELSE IF (:SYSTYPEID = 1) THEN
		VALI = CAST(VAL AS INTEGER);
	ELSE
		VALS = VAL;

	IF (:PARAMPLACEID IS NULL) THEN
		BEGIN
			FOR SELECT PARAMPLACEID FROM PARAMPLACE INTO :TMP DO
			BEGIN
				SELECT COUNT(*) FROM SETUPPARAM WHERE PARAMPLACEID=:TMP AND PARAMID=:PARAMID INTO :FLAG;
				IF (:FLAG > 0) THEN
					UPDATE SETUPPARAM SET VALI=:VALI, VALS=:VALS, VALB=:VALB WHERE PARAMPLACEID=:TMP AND PARAMID=:PARAMID;
				ELSE
					INSERT INTO SETUPPARAM (PARAMID, PARAMPLACEID, DIALOG, VALI, VALS, VALB) VALUES (:PARAMID, :TMP, 0, :VALI, :VALS, :VALB);
			END
		END
	ELSE
		BEGIN
			SELECT COUNT(*) FROM SETUPPARAM WHERE PARAMPLACEID=:PARAMPLACEID AND PARAMID=:PARAMID INTO :FLAG;
			IF (:FLAG > 0) THEN
				UPDATE SETUPPARAM SET VALI=:VALI, VALS=:VALS, VALB=:VALB WHERE PARAMPLACEID=:PARAMPLACEID AND PARAMID=:PARAMID;
			ELSE
				INSERT INTO SETUPPARAM (PARAMID, PARAMPLACEID, DIALOG, VALI, VALS, VALB) VALUES (:PARAMID, :PARAMPLACEID, 0, :VALI, :VALS, :VALB);
		END
		
	SUSPEND;
END