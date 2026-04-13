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
                throw new DirectoryNotFoundException("Pasta do banco não encontrada: " + DatabaseFolder);
            }

            if (!File.Exists(DatabasePath))
            {
                throw new FileNotFoundException("Banco SQLite não encontrado. Verifique o arquivo SmartOilChange.db em Database.", DatabasePath);
            }

            if (new FileInfo(DatabasePath).Length == 0)
            {
                throw new InvalidDataException("O arquivo SmartOilChange.db está vazio.");
            }

            using (var connection = GetConnection())
            {
                connection.Open();
            }
        }
    }
}
