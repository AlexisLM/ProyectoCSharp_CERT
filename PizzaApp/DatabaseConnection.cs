using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    static class DatabaseConnection
    {
        public static SQLiteConnection CreateConnection()
        {
            var connectionString = new SQLiteConnectionStringBuilder();
            connectionString.DataSource = "Pizzas.db";
            connectionString.Version = 3;
            connectionString.Password = "hola123.,";
            var connection = new SQLiteConnection(connectionString.ToString());
            try
            {
                connection.Open();
            }
            catch (SQLiteException)
            {
                return null;
            }
            return connection;
        }

        public static bool ExecuteCommand(SQLiteConnection connection,
            string query)
        {
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
                catch (SQLiteException)
                {
                    transaction.Rollback();
                    return false;
                }
                transaction.Commit();
                return true;
            }
        }



        public static string ReadResult(SQLiteConnection connection, string query)
        {
            using (var transaction = connection.BeginTransaction())
            {
                var result = "";
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandText = query;
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result += $"{reader[i].ToString()}{Environment.NewLine}";
                        }
                    }
                }
                catch (SQLiteException)
                {
                    transaction.Rollback();
                    result = null;
                }
                transaction.Commit();
                return result;
            }
        }

        public static SQLiteDataReader GetResultReader(SQLiteConnection connection, string query)
        {
            try
            {
                var command = connection.CreateCommand();
                command.CommandText = query;
                return command.ExecuteReader();
            }
            catch (SQLiteException)
            {
                return null;
            }
        }
    }
}
