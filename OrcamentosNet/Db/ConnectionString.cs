using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosNet.Db
{
    internal class ConnectionString
    {
        public string connectionString()
        {
            string executableLocation = Assembly.GetExecutingAssembly().Location;
            string executableDirectory = Path.GetDirectoryName(executableLocation);
            string databasePath = Path.Combine(executableDirectory, "database.sqlite");

            return $"Data Source={databasePath};Version=3;";
        }
    }
}
