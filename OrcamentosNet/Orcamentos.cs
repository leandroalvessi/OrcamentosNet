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
    }
}
