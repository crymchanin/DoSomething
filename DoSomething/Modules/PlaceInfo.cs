using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;


namespace DoSomething.Modules
{
    public static class PlaceInfoHelper
    {
        private const string ConnectionString = "User={0};Password={1};Database={2};DataSource={3};Pooling=false;Connection lifetime=60;";

        public class PlaceInfo {
            public string Name { get; set; }
            public string Data { get; set; }
        }


        public static string[] UploadTextFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }


        public static bool TestConnection(string username, string password, string database, string datasource)
        {
            try
            {
                using (FbConnection connection = new FbConnection(string.Format(ConnectionString, username, password, database, datasource)))
                {
                    connection.Open();

                    bool result = (connection.State == ConnectionState.Open);

                    return result;
                }
            }
            catch
            {
                return false;
            }
        }

        public static IEnumerable<PlaceInfo> GetPlaceData(string username, string password, string database, string datasource)
        {
            string connStr = "SELECT NAME,SERVADDRESS FROM PLACE WHERE ISVALID = 1";

            using (FbConnection connection = new FbConnection(string.Format(ConnectionString, username, password, database, datasource)))
            {
                connection.Open();

                using (FbCommand command = new FbCommand(connStr, connection))
                {
                    FbTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    using (FbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["NAME"].ToString();
                            string data = reader["SERVADDRESS"].ToString();

                            yield return new PlaceInfo { Name = name, Data = data };
                        }
                    }
                    transaction.Rollback();
                }
            }
        }

        public static void SetPlaceData(string username, string password, string database, string datasource, string data)
        {
            string connStr = "UPDATE PLACE " +
                          "SET SERVADDRESS = '" + data + "' " +
                          "WHERE ISVALID = 1";

            using (FbConnection connection = new FbConnection(string.Format(ConnectionString, username, password, database, datasource)))
            {
                connection.Open();

                using (FbCommand command = new FbCommand(connStr, connection))
                {
                    using (FbTransaction transaction = connection.BeginTransaction())
                    {
                        command.Transaction = transaction;
                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }
            }
        }
    }
}
