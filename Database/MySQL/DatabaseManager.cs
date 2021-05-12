using System;
using System.Collections.Generic;
using System.Data;
using I18N.West;
using MySql.Data.MySqlClient;

namespace SolokLibrary.Database.MySQL
{
    public static class DatabaseManager
    {
        // PVT. FIELDS
        private static MySqlConnection _con;
        
        // METHODS
        public static void SetupMySql(string server, string database, string charset, string uid, string password,
            string logMessage)
        {
            _con = new MySqlConnection(
                $"Server={server};Database={database};charset={charset};uid={uid};password={password}");
            try
            {
                _con.Open();
                if (_con.State == ConnectionState.Open)
                    Logger.SLogger.Log(logMessage);
            }
            catch (MySqlException exceptionMessage)
            {
                Console.WriteLine(exceptionMessage);
            }
        }

        public static bool DatabaseHaveData(string tableName, string data, string column)
        {
            try
            {
                var com = new MySqlCommand($"SELECT * FROM {tableName} WHERE {column} = @data", _con);
                com.Parameters.AddWithValue("@data", data);
                var read = com.ExecuteReader();
                if (read.Read())
                {
                    _con.Close();
                    return true;
                }

                _con.Close();
                return false;
            }
            catch (MySqlException exceptionMessage)
            {
                Console.WriteLine(exceptionMessage);
                return false;
            }
        }
        public static void DeleteData(string tableName, string data, string column)
        {
            try
            {
                _con.Open();
                var sql = new MySqlCommand($"SELECT * FROM {tableName} WHERE {column}=@data", _con);
                sql.Parameters.AddWithValue("@data", data);
                sql = new MySqlCommand($"DELETE FROM {tableName} WHERE {column}=@data", _con);
                sql.Parameters.AddWithValue("@data", data);
                sql.ExecuteNonQuery();
                _con.Close();
            }
            catch (MySqlException exceptionMessage)
            {
                Console.WriteLine(exceptionMessage);
            }
        }
        public static void InsertData(string tableName, string data, string column)
        {
            try
            {
                _con.Open();
                var createData = new MySqlCommand($"INSERT INTO {tableName} ({column}) VALUES(@data)", _con);
                createData.Parameters.AddWithValue("@data", data);
                createData.ExecuteNonQuery();
            }
            catch (MySqlException exceptionMessage)
            {
                Console.WriteLine(exceptionMessage);
            }
        }
        public static void UpdateData(string tableName, string oldData, string column, string newData)
        {
            try
            {
                _con.Open();
                var cmd = new MySqlCommand($"UPDATE {tableName} SET {oldData}=@newData WHERE {column}=@{oldData}",
                    _con);
                cmd.Parameters.AddWithValue("@newData", newData);
                cmd.ExecuteNonQuery();
                _con.Close();
            }
            catch (MySqlException exceptionMessage)
            {
                Console.WriteLine(exceptionMessage);
            }
        }
    }
}