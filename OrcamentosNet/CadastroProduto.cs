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

namespace OrcamentosNet
{
    public partial class CadastroProduto : Form
    {
        private bool bSalva = true;
        private int id;
        public CadastroProduto(Produto produto)
        {
            InitializeComponent();

            if (produto.Id != 0)
            {
                this.id = produto.Id;
                textBoxDescricao.Text = produto.Descricao;
                textBoxValor.Text = produto.Valor.ToString("C2");
                bSalva = false;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ProdutoController produtoController = new ProdutoController();
            Produto novoProduto;

            decimal valor = 0;

            if (!string.IsNullOrWhiteSpace(textBoxValor.Text))
            {
                string valorFormatado = textBoxValor.Text
                    .Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "")
                    .Replace(CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator, "")
                    .Trim();

                if (decimal.TryParse(valorFormatado, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorConvertido))
                {
                    valor = valorConvertido;
                }
            }

            if (bSalva)
            {
                novoProduto = new Produto();
                novoProduto.Descricao = textBoxDescricao.Text;
                novoProduto.Valor = valor;

                produtoController.SalvarProduto(novoProduto, out this.id);

                if (this.id > 0)
                {
                    MessageBox.Show("Produto salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                novoProduto = new Produto();
                novoProduto.Id = this.id;
                novoProduto.Descricao = textBoxDescricao.Text;
                novoProduto.Valor = valor;


                if (produtoController.EditarProduto(novoProduto))
                {
                    MessageBox.Show("Orcamento editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void textBoxValor_Leave(object sender, EventArgs e)
        {
            string valor = textBoxValor.Text.Trim();

            if (!valor.Contains(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator))
            {
                textBoxValor.Text = $"{valor}{CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator}00";
            }

            if (decimal.TryParse(textBoxValor.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorAux))
            {
                textBoxValor.Text = valorAux.ToString("C2");
            }
        }
    }
}
