using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosNet.Db
{
    internal class SQLiteConnectionManager
    {
        private string databasePath;
        private string connectionString;

        public SQLiteConnectionManager()
        {
            databasePath = Path.Combine(Directory.GetCurrentDirectory(), "database.db");
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());
            connectionString = $"Data Source={databasePath}";
        }

        public SqliteConnection OpenConnection()
        {
            SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();

            return connection;
        }

        public void CloseConnection(SqliteConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
