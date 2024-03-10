using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosNet.Db
{
    internal class DatabaseManager
    {
        public void CriarBancoDados()
        {
            string executableLocation = Assembly.GetExecutingAssembly().Location;
            string executableDirectory = Path.GetDirectoryName(executableLocation);
            string databasePath = Path.Combine(executableDirectory, "database.db");

            if (!File.Exists(databasePath))
            {
                using (File.Create(databasePath)) { }

                Console.WriteLine("Arquivo do banco de dados e tabela criados com sucesso.");
            }
            else
            {
                Console.WriteLine("O arquivo do banco de dados já existe.");
            }
        }
    }
}
