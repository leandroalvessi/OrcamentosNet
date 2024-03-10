using OrcamentosNet.Db;
using OrcamentosNet.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentosNet.Controllers
{
    internal class ProdutoController
    {
        private SQLiteConnectionManager connectionManager;
        private SQLiteConnection connection;
        public List<Produto> ObterProdutos()
        {
            connectionManager = new SQLiteConnectionManager();
            List<Produto> produtos = new List<Produto>();

            try
            {
                connection = connectionManager.GetConnection();
                string query = "SELECT Id, Descricao, Valor FROM Produto";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Produto produto = new Produto();
                                produto.Id = reader.GetInt32(0);
                                produto.Descricao = reader.GetString(1);
                                produto.Valor = reader.GetDecimal(2);
                                produtos.Add(produto);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há resultados.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return produtos;
        }

        public void SalvarProduto(Produto produto, out int id)
        {
            connectionManager = new SQLiteConnectionManager();

            id = 0;

            try
            {
                connection = connectionManager.GetConnection();

                string query = @"INSERT INTO Produto (Descricao, Valor) 
                                VALUES (@Descricao, @Valor); SELECT last_insert_rowid();"
                ;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                    command.Parameters.AddWithValue("@Valor", produto.Valor);

                    id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar o orcamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool EditarProduto(Produto produto)
        {
            connectionManager = new SQLiteConnectionManager();

            try
            {
                connection = connectionManager.GetConnection();

                string query = @"UPDATE Produto SET Descricao = @Descricao, Valor = @Valor
                                 WHERE Id = @Id"
                ;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                    command.Parameters.AddWithValue("@Valor", produto.Valor);
                    command.Parameters.AddWithValue("@Id", produto.Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao editar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool DeletarProduto(int id)
        {
            connectionManager = new SQLiteConnectionManager();
            SQLiteTransaction transaction = null;

            try
            {
                connection = connectionManager.GetConnection();
                using (transaction = connection.BeginTransaction())
                {
                    string deleteOrcamentoQuery = "DELETE FROM Produto WHERE Id = @Id";

                    using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteOrcamentoQuery, connection, transaction))
                    {
                        deleteCommand.Parameters.AddWithValue("@Id", id);
                        deleteCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao deletar o item do produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (transaction != null)
                    transaction.Rollback();
                return false;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
