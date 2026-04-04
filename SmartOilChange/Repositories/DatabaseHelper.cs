using System;
using System.Data.SQLite;
using System.IO;

namespace SmartOilChange.Repositories
{
    internal class DatabaseHelper
    {
        private static readonly string DatabaseFolder =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Database"));

        private static readonly string DatabasePath =
            Path.Combine(DatabaseFolder, "SmartOilChange.db");

        private static readonly string ConnectionString =
            "Data Source=" + DatabasePath + ";Version=3;Foreign Keys=True;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public static void InitializeDatabase()
        {
            if (!Directory.Exists(DatabaseFolder))
            {
                Directory.CreateDirectory(DatabaseFolder);
            }

            bool isNewDatabase = !File.Exists(DatabasePath);

            if (isNewDatabase)
            {
                SQLiteConnection.CreateFile(DatabasePath);
            }

            using (var connection = GetConnection())
            {
                connection.Open();

                if (isNewDatabase)
                {
                    ExecuteSqlFile(connection, Path.Combine(DatabaseFolder, "schema.sql"));
                    ExecuteSqlFile(connection, Path.Combine(DatabaseFolder, "seed.sql"));
                }
            }
        }

        private static void ExecuteSqlFile(SQLiteConnection connection, string filePath)
        {
            if (!File.Exists(filePath))
                return;

            string sql = File.ReadAllText(filePath);

            using (var command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
