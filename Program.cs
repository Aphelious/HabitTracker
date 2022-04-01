using System;
using Microsoft.Data.Sqlite;

namespace HabitTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=HabitTracker.db";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText = "";
                tableCmd.ExecuteNonQuery();
                connection.Close();
                
            }
        }
    }
}