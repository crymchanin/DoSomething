using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Data;
using System.IO;


namespace DoSomething.Modules {
    public static class PlaceInfoHelper {

        public class PlaceInfo {
            public string Name { get; set; }
            public string Data { get; set; }
        }


        public static string[] UploadTextFile(string filePath) {
            return File.ReadAllLines(filePath);
        }

        public static void SaveTextFile(string filePath, string data) {
            File.WriteAllText(filePath, data);
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

        public static IEnumerable<PlaceInfo> GetPlaceData(string connectionString) {
            string connStr = "SELECT NAME,SERVADDRESS FROM PLACE WHERE ISVALID = 1";

            using (FbConnection connection = new FbConnection(connectionString)) {
                connection.Open();

                using (FbCommand command = new FbCommand(connStr, connection)) {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    using (FbDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            string name = reader["NAME"].ToString();
                            string data = reader["SERVADDRESS"].ToString();

                            yield return new PlaceInfo { Name = name, Data = data };
                        }
                    }
                    transaction.Rollback();
                }
            }
        }

        public static void SetPlaceData(string connectionString, string data) {
            string connStr = "UPDATE PLACE " +
                          "SET SERVADDRESS = '" + data + "' " +
                          "WHERE ISVALID = 1";

            using (FbConnection connection = new FbConnection(connectionString)) {
                connection.Open();

                using (FbCommand command = new FbCommand(connStr, connection)) {
                    using (FbTransaction transaction = connection.BeginTransaction()) {
                        command.Transaction = transaction;
                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }
            }
        }
    }
}
