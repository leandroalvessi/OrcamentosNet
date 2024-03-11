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
    public partial class ListaProduto : Form
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }

        public decimal ValorProduto { get; set; }
        public ListaProduto()
        {
            InitializeComponent();

            dataGridViewProdutos.CellDoubleClick += dataGridViewProdutos_CellDoubleClick;
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            ProdutoController produtoController = new ProdutoController();
            List<Produto> produtoLista = new List<Produto>();
            produtoLista = produtoController.ObterProdutos();

            dataGridViewProdutos.Rows.Clear();
            foreach (Produto produto in produtoLista)
            {
                dataGridViewProdutos.Rows.Add(produto.Id, produto.Descricao, produto.Valor);
            }
        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell Id = dataGridViewProdutos.Rows[e.RowIndex].Cells["Id"];
                DataGridViewCell Descricao = dataGridViewProdutos.Rows[e.RowIndex].Cells["Descricao"];
                DataGridViewCell Valor = dataGridViewProdutos.Rows[e.RowIndex].Cells["Valor"];

                IdProduto = Convert.ToInt32(Id.Value);
                DescricaoProduto = Descricao.Value.ToString();
                ValorProduto = Convert.ToDecimal(Valor.Value);

                this.Close();
            }
        }
    }
}
