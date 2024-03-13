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
    internal class ItemOrcamentoController
    {
        private SQLiteConnectionManager connectionManager;
        private SQLiteConnection connection;

        public List<ItemOrcamentoGridView> ObterItemsOrcamentos(int IdItems)
        {
            connectionManager = new SQLiteConnectionManager();
            List<ItemOrcamentoGridView> itemOrcamentoGridView = new List<ItemOrcamentoGridView>();

            try
            {
                connection = connectionManager.GetConnection();

                string query = @"SELECT P.Id, P.Descricao, I.Quantidade, P.Valor
                                 FROM ItemOrcamento I
                                 INNER JOIN Produto P ON I.IdProduto = P.Id
                                 WHERE I.IdOrcamento = @IdOrcamento"
                ;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@IdOrcamento", IdItems);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                itemOrcamentoGridView.Add(new ItemOrcamentoGridView(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDecimal(3)));
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

            return itemOrcamentoGridView;
        }

        public bool SalvarItemOrcamento(DataGridView grid, int CodigoOrcamento)
        {
            connectionManager = new SQLiteConnectionManager();

            try
            {
                connection = connectionManager.GetConnection();
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    string deleteItemQuery = "DELETE FROM ItemOrcamento WHERE IdOrcamento = @IdOrcamento";

                    using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteItemQuery, connection, transaction))
                    {
                        deleteCommand.Parameters.AddWithValue("@IdOrcamento", CodigoOrcamento);
                        deleteCommand.ExecuteNonQuery();
                    }

                    string insertItemQuery = "INSERT INTO ItemOrcamento (IdOrcamento, IdProduto, Quantidade) VALUES (@IdOrcamento, @IdProduto, @Quantidade)";

                    using (SQLiteCommand itemCommand = new SQLiteCommand(insertItemQuery, connection, transaction))
                    {
                        foreach (DataGridViewRow row in grid.Rows)
                        {
                            ItemOrcamento item = new ItemOrcamento
                            {
                                IdOrcamento = CodigoOrcamento,
                                IdProduto = Convert.ToInt32(row.Cells["Codigo"].Value),
                                Quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value)
                            };

                            itemCommand.Parameters.Clear();
                            itemCommand.Parameters.AddWithValue("@IdOrcamento", item.IdOrcamento);
                            itemCommand.Parameters.AddWithValue("@IdProduto", item.IdProduto);
                            itemCommand.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                            itemCommand.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar o item do orcamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool DeletarOrcamentoItems(int id)
        {
            connectionManager = new SQLiteConnectionManager();
            SQLiteTransaction transaction = null;

            try
            {
                connection = connectionManager.GetConnection();
                connection.Open();

                using (transaction = connection.BeginTransaction())
                {
                    string deleteItemQuery = "DELETE FROM ItemOrcamento WHERE IdOrcamento = @Id";

                    using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteItemQuery, connection, transaction))
                    {
                        deleteCommand.Parameters.AddWithValue("@Id", id);
                        deleteCommand.ExecuteNonQuery();
                    }
                    string deleteOrcamentoQuery = "DELETE FROM Orcamento WHERE Id = @Id";

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
                MessageBox.Show($"Ocorreu um erro ao deletar o item do orcamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
