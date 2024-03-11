using OrcamentosNet.Controllers;
using OrcamentosNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OrcamentosNet
{
    public partial class CadastroOrcamento : Form
    {
        public decimal ValorProduto;
        private bool bSalva = true;
        private int id;
        public CadastroOrcamento(Orcamento orcamento)
        {
            InitializeComponent();

            textBoxId.KeyPress += textBoxId_KeyPress;

            if (orcamento.Id != 0)
            {
                this.id = orcamento.Id;
                textBoxNome.Text = orcamento.Nome;

                if (orcamento.TipoInscricao == 1)
                {
                    radioButtonCPF.Checked = true;
                    radioButtonCNPJ.Checked = false;
                }
                else
                {
                    radioButtonCPF.Checked = false;
                    radioButtonCNPJ.Checked = true;
                }

                maskedTextBoxCPFCNPJ.Text = orcamento.Inscricao;
                maskedTextBoxTelefone1.Text = orcamento.Telefone1;
                maskedTextBoxTelefone2.Text = orcamento.Telefone2;
                textBoxEmail.Text = orcamento.Email;
                textBoxEndereco.Text = orcamento.Endereco;
                textBoxBairro.Text = orcamento.Bairro;
                textBoxUF.Text = orcamento.Uf;
                textBoxCidade.Text = orcamento.Cidade;
                maskedTextBoxCEP.Text = orcamento.Cep;
                textBoxDesconto.Text = orcamento.ValorDesconto.ToString("C2");

                bSalva = false;
            }
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            ItemOrcamentoController itemOrcamentoController = new ItemOrcamentoController();
            List<ItemOrcamentoGridView> itemOrcamentoGridView = new List<ItemOrcamentoGridView>();
            itemOrcamentoGridView = itemOrcamentoController.ObterItemsOrcamentos(this.id);

            dataGridViewProdutos.Rows.Clear();
            foreach (ItemOrcamentoGridView item in itemOrcamentoGridView)
            {
                dataGridViewProdutos.Rows.Add(item.Id, item.Descricao, item.Quantidade, item.Valor, item.Valor * item.Quantidade);
            }
            CalcularTotalGeral();
        }

        private void CalcularTotalGeral()
        {
            decimal totalGeral = 0;

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
            {
                if (decimal.TryParse(row.Cells["Quantidade"].Value.ToString(), out decimal quantidade) &&
                    decimal.TryParse(row.Cells["Valor"].Value.ToString(), out decimal valor))
                {
                    decimal totalItem = quantidade * valor;
                    row.Cells["Total"].Value = totalItem;
                    totalGeral += totalItem;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBoxDesconto.Text))
            {
                string valorFormatado = textBoxDesconto.Text
                    .Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "")
                    .Replace(CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator, "")
                    .Trim();

                if (decimal.TryParse(valorFormatado, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorConvertido))
                {
                    totalGeral -= valorConvertido;
                }
            }

            textBoxTotalGeral.Text = totalGeral.ToString("C2");
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButtonCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCPF.Checked)
            {
                radioButtonCNPJ.Checked = false;
                maskedTextBoxCPFCNPJ.Mask = "000,000,000-00";
                maskedTextBoxCPFCNPJ.Clear();
            }
        }

        private void textBoxDescricao_DoubleClick(object sender, EventArgs e)
        {
            ListaProduto listaProduto = new ListaProduto();
            listaProduto.ShowDialog();

            textBoxId.Text = listaProduto.IdProduto.ToString();
            textBoxDescricao.Text = listaProduto.DescricaoProduto;
            ValorProduto = listaProduto.ValorProduto;
        }

        private void dataGridViewProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProdutos.Columns["Quantidade"].Index && e.RowIndex != -1)
            {
                int quantidade;
                if (!int.TryParse(dataGridViewProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("A quantidade deve ser um número inteiro maior que zero.");
                    dataGridViewProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                    return;
                }

                decimal valor = Convert.ToDecimal(dataGridViewProdutos.Rows[e.RowIndex].Cells["Valor"].Value);
                decimal total = quantidade * valor;
                dataGridViewProdutos.Rows[e.RowIndex].Cells["Total"].Value = total;
                CalcularTotalGeral();
            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            OrcamentoController orcamentroController = new OrcamentoController();
            ItemOrcamentoController itemOrcamentoController = new ItemOrcamentoController();
            Orcamento novoOrcamento;
            decimal valorDesconto = 0;

            if (!string.IsNullOrWhiteSpace(textBoxDesconto.Text))
            {
                string valorFormatado = textBoxDesconto.Text
                    .Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "")
                    .Replace(CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator, "")
                    .Trim();

                if (decimal.TryParse(valorFormatado, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorConvertido))
                {
                    valorDesconto = valorConvertido;
                }
            }

            if (bSalva)
            {
                novoOrcamento = new Orcamento();
                novoOrcamento.Nome = textBoxNome.Text;
                novoOrcamento.ValorDesconto = valorDesconto;
                novoOrcamento.Inscricao = maskedTextBoxCPFCNPJ.Text;
                novoOrcamento.Telefone1 = maskedTextBoxTelefone1.Text;
                novoOrcamento.Telefone2 = maskedTextBoxTelefone2.Text;
                novoOrcamento.Email = textBoxEmail.Text;
                novoOrcamento.Endereco = textBoxEndereco.Text;
                novoOrcamento.Bairro = textBoxBairro.Text;
                novoOrcamento.Uf = textBoxUF.Text;
                novoOrcamento.Cep = maskedTextBoxCEP.Text;
                novoOrcamento.Cidade = textBoxCidade.Text;

                if (radioButtonCPF.Checked)
                {
                    novoOrcamento.TipoInscricao = 1;
                }
                else
                {
                    novoOrcamento.TipoInscricao = 2;
                }

                orcamentroController.SalvarOrcamento(novoOrcamento, out this.id);

                if (this.id > 0)
                {
                    if (dataGridViewProdutos.RowCount > 0)
                    {
                        itemOrcamentoController.SalvarItemOrcamento(dataGridViewProdutos, this.id);
                        MessageBox.Show("Orcamento salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
            }
            else
            {
                novoOrcamento = new Orcamento();
                novoOrcamento.Id = this.id;
                novoOrcamento.Nome = textBoxNome.Text;
                novoOrcamento.ValorDesconto = valorDesconto;
                novoOrcamento.Inscricao = maskedTextBoxCPFCNPJ.Text;
                novoOrcamento.Telefone1 = maskedTextBoxTelefone1.Text;
                novoOrcamento.Telefone2 = maskedTextBoxTelefone2.Text;
                novoOrcamento.Email = textBoxEmail.Text;
                novoOrcamento.Endereco = textBoxEndereco.Text;
                novoOrcamento.Bairro = textBoxBairro.Text;
                novoOrcamento.Uf = textBoxUF.Text;
                novoOrcamento.Cep = maskedTextBoxCEP.Text;
                novoOrcamento.Cidade = textBoxCidade.Text;

                if (radioButtonCPF.Checked)
                {
                    novoOrcamento.TipoInscricao = 1;
                }
                else
                {
                    novoOrcamento.TipoInscricao = 2;
                }

                if (orcamentroController.EditarOrcamento(novoOrcamento))
                {
                    itemOrcamentoController.SalvarItemOrcamento(dataGridViewProdutos, this.id);
                    MessageBox.Show("Orcamento editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void radioButtonCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCNPJ.Checked)
            {
                radioButtonCPF.Checked = false;
                maskedTextBoxCPFCNPJ.Mask = "00,000,000/0000-00";
                maskedTextBoxCPFCNPJ.Clear();
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            ProdutoController produtoController = new ProdutoController();
            List<Produto> produtosLista = new List<Produto>();
            produtosLista = produtoController.ObterProdutos();

            if (textBoxId.Text != "0")
            {
                if (!string.IsNullOrEmpty(textBoxId.Text))
                {
                    string id = textBoxId.Text;

                    if (int.TryParse(id, out int idInt))
                    {
                        Produto produto = produtosLista.Find(o => o.Id == idInt);

                        if (produto != null)
                        {
                            textBoxDescricao.Text = produto.Descricao;
                            ValorProduto = produto.Valor;
                        }
                        else
                        {
                            MessageBox.Show("O produto não foi encontrado. Por favor, verifique se o produto informado existe na lista.", "Produto Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxDescricao.Clear();
                            textBoxId.Clear();
                        }
                    }
                }
                else
                {
                    textBoxDescricao.Clear();
                    textBoxId.Clear();
                }
            }
            else
            {
                textBoxDescricao.Clear();
                textBoxId.Clear();
            }
        }

        private bool CamposVazios()
        {
            if (string.IsNullOrEmpty(textBoxId.Text) ||
                string.IsNullOrEmpty(textBoxDescricao.Text) ||
                textBoxId.Text == "0")
            {
                return true;
            }
            return false;
        }

        private bool CodigoExistente(string codigo)
        {
            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
            {
                if (row.Cells["Codigo"].Value != null && row.Cells["Codigo"].Value.ToString() == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonAdiciona_Click(object sender, EventArgs e)
        {
            if (!CamposVazios())
            {
                string codigo = textBoxId.Text;

                if (!CodigoExistente(codigo))
                {
                    dataGridViewProdutos.Rows.Add(textBoxId.Text, textBoxDescricao.Text, 1, ValorProduto, ValorProduto * 1);
                    CalcularTotalGeral();
                }
                else
                {
                    MessageBox.Show("O código já existe na grade. Por favor, insira um código único.", "Código Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos. Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridViewProdutos.SelectedRows[0];
                dataGridViewProdutos.Rows.Remove(linhaSelecionada);
                CalcularTotalGeral();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para deletar.", "Nenhuma Linha Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxDesconto_Leave(object sender, EventArgs e)
        {
            string valorDesconto = textBoxDesconto.Text.Trim();

            if (!valorDesconto.Contains(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                textBoxDesconto.Text = $"{valorDesconto}{CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator}00";
            }

            if (decimal.TryParse(textBoxDesconto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valor))
            {
                textBoxDesconto.Text = valor.ToString("C2");
                CalcularTotalGeral();
            }
        }
    }
}
