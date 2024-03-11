using OrcamentosNet.Controllers;
using OrcamentosNet.Db;
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
    public partial class Orcamentos : Form
    {
        public Orcamentos()
        {
            InitializeComponent();

            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            OrcamentoController orcamentroController = new OrcamentoController();
            List<Orcamento> orcamentosLista = new List<Orcamento>();
            orcamentosLista = orcamentroController.ObterOrcamentos();

            dataGridViewOrcamentos.Rows.Clear();
            foreach (Orcamento orcamento in orcamentosLista)
            {
                dataGridViewOrcamentos.Rows.Add(orcamento.Id, orcamento.Nome, orcamento.Cep, orcamento.TipoInscricao, orcamento.Inscricao,
                                                orcamento.Telefone1, orcamento.Telefone1, orcamento.Email, orcamento.Endereco, orcamento.Bairro,
                                                orcamento.Uf, orcamento.Cidade, orcamento.Valor, orcamento.ValorDesconto, orcamento.ValorTotal, orcamento.DataCriacao);
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            CadastroOrcamento cadastroOrcamento = new CadastroOrcamento(orcamento);
            cadastroOrcamento.ShowDialog();
            AtualizaGrid();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditarClick();
        }

        private void EditarClick()
        {
            if (dataGridViewOrcamentos.SelectedRows.Count > 0)
            {
                OrcamentoController orcamentroController = new OrcamentoController();
                Orcamento orcamento = new Orcamento();

                int rowIndex = dataGridViewOrcamentos.SelectedRows[0].Index;

                orcamento.Id = Convert.ToInt16(dataGridViewOrcamentos.Rows[rowIndex].Cells[0].Value.ToString());
                orcamento.Nome = dataGridViewOrcamentos.Rows[rowIndex].Cells[1].Value.ToString();
                orcamento.Cep = dataGridViewOrcamentos.Rows[rowIndex].Cells[2].Value.ToString();
                orcamento.TipoInscricao = Convert.ToInt16(dataGridViewOrcamentos.Rows[rowIndex].Cells[3].Value.ToString());
                orcamento.Inscricao = dataGridViewOrcamentos.Rows[rowIndex].Cells[4].Value.ToString();
                orcamento.Telefone1 = dataGridViewOrcamentos.Rows[rowIndex].Cells[5].Value.ToString();
                orcamento.Telefone2 = dataGridViewOrcamentos.Rows[rowIndex].Cells[6].Value.ToString();
                orcamento.Email = dataGridViewOrcamentos.Rows[rowIndex].Cells[7].Value.ToString();
                orcamento.Endereco = dataGridViewOrcamentos.Rows[rowIndex].Cells[8].Value.ToString();
                orcamento.Bairro = dataGridViewOrcamentos.Rows[rowIndex].Cells[9].Value.ToString();
                orcamento.Uf = dataGridViewOrcamentos.Rows[rowIndex].Cells[10].Value.ToString();
                orcamento.Cidade = dataGridViewOrcamentos.Rows[rowIndex].Cells[11].Value.ToString();
                orcamento.Valor = Convert.ToDecimal(dataGridViewOrcamentos.Rows[rowIndex].Cells[12].Value.ToString());
                orcamento.ValorDesconto = Convert.ToDecimal(dataGridViewOrcamentos.Rows[rowIndex].Cells[13].Value.ToString());

                CadastroOrcamento cadastroOrcamento = new CadastroOrcamento(orcamento);

                cadastroOrcamento.ShowDialog();
                AtualizaGrid();
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrcamentos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Você deseja realmente deletar o orçamento?", "Confirmação de Deleção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ItemOrcamentoController itemOrcamentoController = new ItemOrcamentoController();

                    int rowIndex = dataGridViewOrcamentos.SelectedRows[0].Index;

                    if (itemOrcamentoController.DeletarOrcamentoItems(Convert.ToInt16(dataGridViewOrcamentos.Rows[rowIndex].Cells[0].Value.ToString())))
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
