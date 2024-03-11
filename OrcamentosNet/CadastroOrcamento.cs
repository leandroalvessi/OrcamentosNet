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
            //
        }

        private void radioButtonCPF_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
