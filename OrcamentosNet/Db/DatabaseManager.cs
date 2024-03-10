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
    internal class DatabaseManager
    {
        private SQLiteConnectionManager connectionManager;

        public void CriarBancoDados()
        {
            connectionManager = new SQLiteConnectionManager();
            ConnectionString connString = new ConnectionString();

            if (!File.Exists(connString.connectionString()))
            {
                try
                {
                    using (var connection = connectionManager.GetConnection())
                    {
                        connection.Open();

                        string query = @"
                    CREATE TABLE IF NOT EXISTS ItemOrcamento (
                        Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        IdOrcamento INTEGER NOT NULL,
                        IdProduto INTEGER NOT NULL,
                        Quantidade INTEGER
                    );

                    CREATE TABLE IF NOT EXISTS Produto (
                        Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        Descricao TEXT NOT NULL,
                        Valor NUMERIC NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Orcamento (
                        Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        DataCriacao TEXT NOT NULL,
                        ValorDesconto NUMERIC,
                        Cep TEXT,
                        TipoInscricao INTEGER NOT NULL,
                        Inscricao TEXT NOT NULL,
                        Telefone1 TEXT,
                        Telefone2 TEXT,
                        Email TEXT,
                        Endereco TEXT,
                        Bairro TEXT,
                        Uf TEXT,
                        Cidade TEXT
                    );";

                        using (var command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro ao criar o banco de dados: {ex.Message}");
                    throw;
                }
            }
            else
            {
                Console.WriteLine("O arquivo do banco de dados já existe.");
            }
        }
    }
}
