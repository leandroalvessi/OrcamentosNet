using OrcamentosNet.Controllers;
using OrcamentosNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentosNet
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            ProdutoController produtoController = new ProdutoController();
            List<Produto> produtosLista = new List<Produto>();
            produtosLista = produtoController.ObterProdutos();

            dataGridViewProdutos.Rows.Clear();
            foreach (Produto produto in produtosLista)
            {
                dataGridViewProdutos.Rows.Add(produto.Id, produto.Descricao, produto.Valor);
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            CadastroProduto cadastroProduto = new CadastroProduto(produto);
            cadastroProduto.ShowDialog();
            AtualizaGrid();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                ProdutoController orcamentroController = new ProdutoController();
                Produto produto = new Produto();

                int rowIndex = dataGridViewProdutos.SelectedRows[0].Index;

                produto.Id = Convert.ToInt16(dataGridViewProdutos.Rows[rowIndex].Cells[0].Value.ToString());
                produto.Descricao = dataGridViewProdutos.Rows[rowIndex].Cells[1].Value.ToString();
                produto.Valor = Convert.ToDecimal(dataGridViewProdutos.Rows[rowIndex].Cells[2].Value.ToString());

                CadastroProduto cadastroProduto = new CadastroProduto(produto);

                cadastroProduto.ShowDialog();
                AtualizaGrid();
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Você deseja realmente deletar o produto?", "Confirmação de Deleção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ProdutoController produtoController = new ProdutoController();

                    int rowIndex = dataGridViewProdutos.SelectedRows[0].Index;

                    if (produtoController.DeletarProduto(Convert.ToInt16(dataGridViewProdutos.Rows[rowIndex].Cells[0].Value.ToString())))
                    {
                        AtualizaGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
