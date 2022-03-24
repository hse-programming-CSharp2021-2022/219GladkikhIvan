using System;
using Microsoft.Data.Sqlite;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=MyDB7.db";
            SqliteConnection con = new SqliteConnection(connectionString);
            con.Open();
            SqliteCommand command = new SqliteCommand();
            command.Connection = con;
            command.CommandText = "CREATE TABLE Users3(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, name TEXT NOT NULL)";
            command.ExecuteNonQuery();

            command.CommandText = "INSERT INTO Users3(name) VALUES ('Tom')";
            command.ExecuteNonQuery();

            command.CommandText = "INSERT INTO Users3 (name) VALUES ('Bob')";
            command.ExecuteNonQuery();

            command.CommandText = "INSERT INTO Users3(name) VALUES ('Alice')";
            command.ExecuteNonQuery();

            command.CommandText = "UPDATE Users3 SET name='BobUpdated' WHERE name='Bob'";
            command.ExecuteNonQuery();

            command.CommandText = "DELETE FROM Users3 WHERE name='Tom'";
            command.ExecuteNonQuery();

            command.CommandText = "UPDATE Users3 SET name='Alice1' WHERE id='3'";
            command.ExecuteNonQuery();

            command.CommandText = "SELECT * FROM Users3";
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1));
            }
        }
    }
}