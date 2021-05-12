using System;
using System.Collections.Generic;
using System.Threading;
using I18N.West;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;
using SolokLibrary.Logger;

namespace SolokLibrary.Database.MySQL
{
    public class DatabaseManagerV2
    {
        public static string Address;
        public static string Name;
        public static string Password;
        public static uint Port;
        public static string TableName;
        public static string Username;
        
        // CONSTRUCTOR   
        public DatabaseManagerV2(string address, uint port, string username, string password, string name, string tableName, string createTableQuery)
        {
            Address = address;
            Port = port;
            Username = username;
            Password = password;
            Name = name;
            TableName = tableName;
            
            var cp1250 = new CP1250();
            CreateTableSchema(createTableQuery);
        }

        // METHODS
        private static MySqlConnection CreateConnection()
        {
            MySqlConnection connection = null;
            try
            {
                if (Port == 0)
                    Port = 3306;
                connection = new MySqlConnection(
                    $"SERVER={Address};DATABASE={Name};UID={Username};PASSWORD={Password};PORT={Port};");
            }
            catch (Exception ex)
            {
                SLogger.Error(ex.Message);
            }

            return connection;
        }
        private static void CreateTableSchema(string createTableQuery)
        {
            ExecuteQuery(EQueryType.NonQuery,
                $"CREATE TABLE IF NOT EXISTS `{TableName}` {createTableQuery};");
        }
        public static object ExecuteQuery(EQueryType queryType, string query, params MySqlParameter[] parameters)
        {
            object result = null;
            MySqlDataReader reader = null;

            using (var connection = CreateConnection())
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandText = query;

                    foreach (var parameter in parameters)
                        command.Parameters.Add(parameter);

                    connection.Open();
                    switch (queryType)
                    {
                        case EQueryType.Reader:
                            var readerResult = new List<Row>();

                            reader = command.ExecuteReader();
                            while (reader.Read())
                                try
                                {
                                    var values = new Dictionary<string, object>();

                                    for (var i = 0; i < reader.FieldCount; i++)
                                    {
                                        var columnName = reader.GetName(i);
                                        values.Add(columnName, reader[columnName]);
                                    }

                                    readerResult.Add(new Row { Values = values });
                                }
                                catch (Exception ex)
                                {
                                    SLogger.Error(
                                        $"The following query threw an error during reader execution:\nQuery: \"{query}\"\nError: {ex.Message}");
                                }

                            result = readerResult;
                            break;
                        case EQueryType.Scalar:
                            result = command.ExecuteScalar();
                            break;
                        case EQueryType.NonQuery:
                            result = command.ExecuteNonQuery();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(queryType), queryType, null);
                    }
                }
                catch (Exception ex)
                {
                    SLogger.Error(ex.Message);
                }
                finally
                {
                    reader?.Close();
                    connection.Close();
                }
            }

            return result;
        }
        public static bool DatabaseHaveData(string tableName, string data, string column)
        {
            var scalar = ExecuteQuery(EQueryType.Scalar,
                $"SELECT * FROM `{tableName}` WHERE {column} = @data;",
                new MySqlParameter("@data", data));
            return scalar != null;
        }
        public static void DeleteData(string tableName, string data, string column)
        {
            ExecuteQuery(EQueryType.NonQuery,
                $"DELETE FROM `{tableName}` WHERE {column}=@data;", 
                new MySqlParameter("@data", data));
        }
        public static void InsertData(string tableName, string data, string column)
        {
            ExecuteQuery(EQueryType.NonQuery,
                $"INSERT INTO `{tableName}` ({column}) VALUES(@data);", 
                new MySqlParameter("@data", data));
        }
        public static void UpdateData(string tableName, string oldData, string data, string column)
        {
            ExecuteQuery(EQueryType.NonQuery,
                $"UPDATE `{tableName}` SET {oldData}=@newData WHERE {column}=@{oldData};", 
                new MySqlParameter("@newData", data));
        }
    }

    public enum EQueryType
    {
        NonQuery,
        Reader,
        Scalar,
    }

    public class Row
    {
        public Dictionary<string, object> Values;
    }
}