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
    }
}
