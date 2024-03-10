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
    }
}
