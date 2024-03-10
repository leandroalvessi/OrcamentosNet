using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentosNet.Db
{
    internal class SQLiteConnectionManager
    {
        public SQLiteConnection GetConnection()
        {
            ConnectionString connString = new ConnectionString();
            return new SQLiteConnection(connString.connectionString());
        }
    }
}
