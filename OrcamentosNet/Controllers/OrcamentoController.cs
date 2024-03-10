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
    internal class OrcamentoController
    {
        private SQLiteConnectionManager connectionManager;
        private SQLiteConnection connection;
        public List<Orcamento> ObterOrcamentos()
        {
            connectionManager = new SQLiteConnectionManager();
            List<Orcamento> orcamentos = new List<Orcamento>();

            try
            {
                connection = connectionManager.GetConnection();

                string query = @"SELECT 
                                 O.Id, O.Nome, O.Cep, O.TipoInscricao, O.Inscricao, O.Telefone1, O.Telefone2, 
                                 O.Email, O.Endereco, O.Bairro, O.Uf, O.Cidade,
                                 COALESCE((SELECT Sum(I.Quantidade * P.Valor) AS Valor
                                           FROM ItemOrcamento I
                                           INNER JOIN Produto P ON I.IdProduto = P.Id 
                                           WHERE I.IdOrcamento = O.Id), 0) AS Valor,
                                 O.DataCriacao, COALESCE(O.ValorDesconto, 0),
                                 (COALESCE((SELECT Sum(I.Quantidade * P.Valor) AS Valor
                                           FROM ItemOrcamento I
                                           INNER JOIN Produto P ON I.IdProduto = P.Id 
                                           WHERE I.IdOrcamento = O.Id), 0) - COALESCE(O.ValorDesconto, 0)) AS ValorTotal
                                FROM Orcamento O"
                ;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Orcamento orcamento = new Orcamento();
                                orcamento.Id = reader.GetInt32(0);
                                orcamento.Nome = reader.GetString(1);
                                orcamento.Cep = reader.GetString(2);
                                orcamento.TipoInscricao = reader.GetInt32(3);
                                orcamento.Inscricao = reader.GetString(4);
                                orcamento.Telefone1 = reader.GetString(5);
                                orcamento.Telefone2 = reader.GetString(6);
                                orcamento.Email = reader.GetString(7);
                                orcamento.Endereco = reader.GetString(8);
                                orcamento.Bairro = reader.GetString(9);
                                orcamento.Uf = reader.GetString(10);
                                orcamento.Cidade = reader.GetString(11);
                                orcamento.Valor = reader.GetDecimal(12);
                                orcamento.DataCriacao = reader.GetDateTime(13);
                                orcamento.ValorDesconto = reader.GetDecimal(14);
                                orcamento.ValorTotal = reader.GetDecimal(15);
                                orcamentos.Add(orcamento);
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

            return orcamentos;
        }

        public void SalvarOrcamento(Orcamento orcamento, out int id)
        {
            connectionManager = new SQLiteConnectionManager();

            id = 0;

            try
            {
                connection = connectionManager.GetConnection();

                string query = @"INSERT INTO Orcamento (Nome, DataCriacao, ValorDesconto, TipoInscricao, Inscricao, Telefone1, Telefone2, 
                                                        Email, Endereco, Bairro, Uf, Cidade, Cep) 
                                VALUES (@Nome, @DataCriacao, @ValorDesconto, @TipoInscricao, @Inscricao, @Telefone1, @Telefone2, 
                                        @Email, @Endereco, @Bairro, @Uf, @Cidade, @Cep); SELECT last_insert_rowid();"
                ;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Nome", orcamento.Nome);
                    command.Parameters.AddWithValue("@DataCriacao", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@ValorDesconto", orcamento.ValorDesconto);
                    command.Parameters.AddWithValue("@TipoInscricao", orcamento.TipoInscricao);
                    command.Parameters.AddWithValue("@Inscricao", orcamento.Inscricao);
                    command.Parameters.AddWithValue("@Telefone1", orcamento.Telefone1);
                    command.Parameters.AddWithValue("@Telefone2", orcamento.Telefone2);
                    command.Parameters.AddWithValue("@Email", orcamento.Email);
                    command.Parameters.AddWithValue("@Endereco", orcamento.Endereco);
                    command.Parameters.AddWithValue("@Bairro", orcamento.Bairro);
                    command.Parameters.AddWithValue("@Uf", orcamento.Uf);
                    command.Parameters.AddWithValue("@Cidade", orcamento.Cidade);
                    command.Parameters.AddWithValue("@Cep", orcamento.Cep);

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

        public bool EditarOrcamento(Orcamento orcamento)
        {
            connectionManager = new SQLiteConnectionManager();

            try
            {
                connection = connectionManager.GetConnection();

                string query = @"UPDATE Orcamento SET Nome = @Nome, ValorDesconto = @ValorDesconto, TipoInscricao = @TipoInscricao, 
                                  Inscricao = @Inscricao, Telefone1 = @Telefone1, Telefone2 = @Telefone2, Email = @Email, Endereco = @Endereco, 
                                  Bairro = @Bairro, Uf = @Uf, Cidade = @Cidade, Cep = @Cep
                                 WHERE Id = @Id"
                ;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Nome", orcamento.Nome);
                    command.Parameters.AddWithValue("@ValorDesconto", orcamento.ValorDesconto);
                    command.Parameters.AddWithValue("@TipoInscricao", orcamento.TipoInscricao);
                    command.Parameters.AddWithValue("@Inscricao", orcamento.Inscricao);
                    command.Parameters.AddWithValue("@Telefone1", orcamento.Telefone1);
                    command.Parameters.AddWithValue("@Telefone2", orcamento.Telefone2);
                    command.Parameters.AddWithValue("@Email", orcamento.Email);
                    command.Parameters.AddWithValue("@Endereco", orcamento.Endereco);
                    command.Parameters.AddWithValue("@Bairro", orcamento.Bairro);
                    command.Parameters.AddWithValue("@Uf", orcamento.Uf);
                    command.Parameters.AddWithValue("@Cidade", orcamento.Cidade);
                    command.Parameters.AddWithValue("@Cep", orcamento.Cep);
                    command.Parameters.AddWithValue("@Id", orcamento.Id);


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
                MessageBox.Show($"Ocorreu um erro ao editar o orcamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
