using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Data;
using System.IO;


namespace DoSomething.Modules {
    public static class PostItemParHelper {

        public class ParamInfo {
            public int Id { get; set; }
            public string Name { get; set; }
            public short DatatypeId { get; set; }
            public int ParentId { get; set; }
            public string DisplayName { get; set; }
            public short IsPlace { get; set; }
        }

        public class UserInfo {
            public short Id { get; set; }
            public string Name { get; set; }
        }

        public static bool TestConnection(string connectionString) {
            try {
                using (FbConnection connection = new FbConnection(connectionString)) {
                    connection.Open();

                    bool result = (connection.State == ConnectionState.Open);

                    return result;
                }
            }
            catch {
                return false;
            }
        }

        public static IEnumerable<UserInfo> GetUsersList(string connectionString) {
            string connStr = "SELECT PARAMPLACEID,NAME FROM PARAMPLACE;";

            using (FbConnection connection = new FbConnection(connectionString)) {
                connection.Open();

                using (FbCommand command = new FbCommand(connStr, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    using (FbDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            short id = (short)reader["PARAMPLACEID"];
                            string name = (id == 0) ? "Системная учетная запись" : reader["NAME"].ToString();

                            yield return new UserInfo() { Id = id, Name = name };
                        }
                    }
                    transaction.Rollback();
                }
            }
        }

        public static IEnumerable<ParamInfo> GetParamList(string connectionString, List<int> ids) {
            string connStr = "SELECT PARAMID,NAME,DATATYPEID,PARENTID,ISPLACE FROM PARAM WHERE PARAMID IN(" + string.Join(",", ids) + ");";

            using (FbConnection connection = new FbConnection(connectionString)) {
                connection.Open();

                using (FbCommand command = new FbCommand(connStr, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    using (FbDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            int id = (int)reader["PARAMID"];
                            string name = reader["NAME"].ToString();
                            short datatypeid = (short)reader["DATATYPEID"];
                            int parentid = (int)reader["PARENTID"];
                            var v = reader["ISPLACE"].GetType();
                            short isplace = (reader["ISPLACE"].GetType() == typeof(System.DBNull)) ? (short)0 : (short)reader["ISPLACE"];

                            yield return new ParamInfo() { Id = id, Name = name, DatatypeId = datatypeid, ParentId = parentid, IsPlace = isplace };
                        }
                    }
                    transaction.Rollback();
                }
            }
        }

        public static string GetParamParentName(string connectionString, int parentId) {
            string connStr = "SELECT NAME FROM PARAM WHERE PARAMID=" + parentId.ToString() + ";";

            using (FbConnection connection = new FbConnection(connectionString)) {
                connection.Open();

                object result;
                using (FbCommand command = new FbCommand(connStr, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    result = command.ExecuteScalar();
                    transaction.Rollback();
                }

                return (result == null) ? "" : result.ToString();
            }
        }

        public static string GetParamValue(string connectionString, short placeId, int paramId) {
            string connStr = "SELECT COALESCE(VALI, VALS) as VAL " +
                             "FROM SETUPPARAM " +
                             "WHERE PARAMID = " + paramId.ToString() + " " +
                             "AND PARAMPLACEID = " + placeId.ToString() + ";";

            using (FbConnection connection = new FbConnection(connectionString)) {
                connection.Open();

                object result;
                using (FbCommand command = new FbCommand(connStr, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    result = command.ExecuteScalar();
                    transaction.Rollback();
                }

                return (result == null) ? "" : result.ToString();
            }
        }

        public static short SetParamValues(string connectionString, short? placeId, int paramId, short datatypeId, string value) {
            using (FbConnection connection = new FbConnection(connectionString)) {
                connection.Open();

                short result = -1;
                string connStr = Properties.Resources.SetParamValues;
                using (FbCommand command = new FbCommand(connStr, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }

                connStr = string.Format("SELECT * FROM SETPARAMVALUES({0}, {1}, {2}, '{3}')",
                    (placeId.HasValue) ? placeId.ToString() : "NULL",
                    paramId,
                    datatypeId,
                    value);
                using (FbCommand command = new FbCommand(connStr, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    result = (short)command.ExecuteScalar();
                    transaction.Commit();
                }

                connStr = "DROP PROCEDURE SETPARAMVALUES;";
                using (FbCommand command = new FbCommand(connStr, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }

                return result;
            }
        }
    }
}
