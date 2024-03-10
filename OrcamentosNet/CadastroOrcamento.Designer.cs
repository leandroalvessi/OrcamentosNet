namespace OrcamentosNet
{
    partial class CadastroOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroOrcamento));
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.radioButtonCNPJ = new System.Windows.Forms.RadioButton();
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.maskedTextBoxCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefone1 = new System.Windows.Forms.Label();
            this.labelTelefone2 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.ItemOrcamentoGridView = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoInscricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.buttonAdiciona = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemOrcamentoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 28);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(274, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.Location = new System.Drawing.Point(292, 30);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(54, 20);
            this.radioButtonCPF.TabIndex = 2;
            this.radioButtonCPF.TabStop = true;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonCNPJ
            // 
            this.radioButtonCNPJ.AutoSize = true;
            this.radioButtonCNPJ.Location = new System.Drawing.Point(352, 29);
            this.radioButtonCNPJ.Name = "radioButtonCNPJ";
            this.radioButtonCNPJ.Size = new System.Drawing.Size(63, 20);
            this.radioButtonCNPJ.TabIndex = 3;
            this.radioButtonCNPJ.TabStop = true;
            this.radioButtonCNPJ.Text = "CNPJ";
            this.radioButtonCNPJ.UseVisualStyleBackColor = true;
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(418, 4);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(68, 16);
            this.labelCPFCNPJ.TabIndex = 4;
            this.labelCPFCNPJ.Text = "CPFCNPJ";
            // 
            // maskedTextBoxCPFCNPJ
            // 
            this.maskedTextBoxCPFCNPJ.Location = new System.Drawing.Point(421, 27);
            this.maskedTextBoxCPFCNPJ.Mask = "000,000,000-00";
            this.maskedTextBoxCPFCNPJ.Name = "maskedTextBoxCPFCNPJ";
            this.maskedTextBoxCPFCNPJ.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxCPFCNPJ.TabIndex = 5;
            // 
            // maskedTextBoxTelefone1
            // 
            this.maskedTextBoxTelefone1.Location = new System.Drawing.Point(527, 27);
            this.maskedTextBoxTelefone1.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxTelefone1.Name = "maskedTextBoxTelefone1";
            this.maskedTextBoxTelefone1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTelefone1.TabIndex = 7;
            // 
            // labelTelefone1
            // 
            this.labelTelefone1.AutoSize = true;
            this.labelTelefone1.Location = new System.Drawing.Point(524, 4);
            this.labelTelefone1.Name = "labelTelefone1";
            this.labelTelefone1.Size = new System.Drawing.Size(89, 20);
            this.labelTelefone1.TabIndex = 6;
            this.labelTelefone1.Text = "Telefone 1";
            // 
            // labelTelefone2
            // 
            this.labelTelefone2.AutoSize = true;
            this.labelTelefone2.Location = new System.Drawing.Point(630, 4);
            this.labelTelefone2.Name = "labelTelefone2";
            this.labelTelefone2.Size = new System.Drawing.Size(89, 20);
            this.labelTelefone2.TabIndex = 8;
            this.labelTelefone2.Text = "Telefone 2";
            // 
            // maskedTextBoxTelefone2
            // 
            this.maskedTextBoxTelefone2.Location = new System.Drawing.Point(633, 27);
            this.maskedTextBoxTelefone2.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxTelefone2.Name = "maskedTextBoxTelefone2";
            this.maskedTextBoxTelefone2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTelefone2.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 72);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(274, 22);
            this.textBoxEmail.TabIndex = 11;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 53);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 20);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "E-Mail";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(292, 72);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(274, 22);
            this.textBoxEndereco.TabIndex = 13;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(292, 53);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(83, 20);
            this.labelEndereco.TabIndex = 12;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(572, 72);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(161, 22);
            this.textBoxBairro.TabIndex = 15;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(572, 53);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(43, 16);
            this.labelBairro.TabIndex = 14;
            this.labelBairro.Text = "Bairro";
            // 
            // textBoxUF
            // 
            this.textBoxUF.Location = new System.Drawing.Point(12, 116);
            this.textBoxUF.Name = "textBoxUF";
            this.textBoxUF.Size = new System.Drawing.Size(56, 22);
            this.textBoxUF.TabIndex = 17;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(12, 97);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(31, 20);
            this.labelUF.TabIndex = 16;
            this.labelUF.Text = "UF";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(74, 116);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(212, 22);
            this.textBoxCidade.TabIndex = 19;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(74, 97);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(64, 20);
            this.labelCidade.TabIndex = 18;
            this.labelCidade.Text = "Cidade";
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(292, 116);
            this.maskedTextBoxCEP.Mask = "00000-000";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxCEP.TabIndex = 21;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(292, 97);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(34, 16);
            this.labelCEP.TabIndex = 20;
            this.labelCEP.Text = "CEP";
            // 
            // ItemOrcamentoGridView
            // 
            this.ItemOrcamentoGridView.AllowUserToAddRows = false;
            this.ItemOrcamentoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemOrcamentoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemOrcamentoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Cep,
            this.TipoInscricao,
            this.Inscricao,
            this.Telefone1,
            this.Telefone2,
            this.Email,
            this.Endereco,
            this.Bairro,
            this.Uf,
            this.Cidade,
            this.Valor,
            this.ValorDesconto,
            this.Total,
            this.DataCriacao});
            this.ItemOrcamentoGridView.Location = new System.Drawing.Point(11, 272);
            this.ItemOrcamentoGridView.Name = "ItemOrcamentoGridView";
            this.ItemOrcamentoGridView.ReadOnly = true;
            this.ItemOrcamentoGridView.RowHeadersVisible = false;
            this.ItemOrcamentoGridView.RowHeadersWidth = 51;
            this.ItemOrcamentoGridView.RowTemplate.Height = 24;
            this.ItemOrcamentoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemOrcamentoGridView.Size = new System.Drawing.Size(721, 166);
            this.ItemOrcamentoGridView.TabIndex = 22;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Cep
            // 
            this.Cep.HeaderText = "Cep";
            this.Cep.MinimumWidth = 6;
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Visible = false;
            this.Cep.Width = 125;
            // 
            // TipoInscricao
            // 
            this.TipoInscricao.HeaderText = "TipoInscricao";
            this.TipoInscricao.MinimumWidth = 6;
            this.TipoInscricao.Name = "TipoInscricao";
            this.TipoInscricao.ReadOnly = true;
            this.TipoInscricao.Visible = false;
            this.TipoInscricao.Width = 125;
            // 
            // Inscricao
            // 
            this.Inscricao.HeaderText = "Inscricao";
            this.Inscricao.MinimumWidth = 6;
            this.Inscricao.Name = "Inscricao";
            this.Inscricao.ReadOnly = true;
            this.Inscricao.Width = 125;
            // 
            // Telefone1
            // 
            this.Telefone1.HeaderText = "Telefone1";
            this.Telefone1.MinimumWidth = 6;
            this.Telefone1.Name = "Telefone1";
            this.Telefone1.ReadOnly = true;
            this.Telefone1.Visible = false;
            this.Telefone1.Width = 125;
            // 
            // Telefone2
            // 
            this.Telefone2.HeaderText = "Telefone2";
            this.Telefone2.MinimumWidth = 6;
            this.Telefone2.Name = "Telefone2";
            this.Telefone2.ReadOnly = true;
            this.Telefone2.Visible = false;
            this.Telefone2.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            this.Email.Width = 125;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.MinimumWidth = 6;
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Visible = false;
            this.Endereco.Width = 125;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.MinimumWidth = 6;
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Visible = false;
            this.Bairro.Width = 125;
            // 
            // Uf
            // 
            this.Uf.HeaderText = "Uf";
            this.Uf.MinimumWidth = 6;
            this.Uf.Name = "Uf";
            this.Uf.ReadOnly = true;
            this.Uf.Visible = false;
            this.Uf.Width = 125;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.MinimumWidth = 6;
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Visible = false;
            this.Cidade.Width = 125;
            // 
            // Valor
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 110;
            // 
            // ValorDesconto
            // 
            this.ValorDesconto.HeaderText = "ValorDesconto";
            this.ValorDesconto.MinimumWidth = 6;
            this.ValorDesconto.Name = "ValorDesconto";
            this.ValorDesconto.ReadOnly = true;
            this.ValorDesconto.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // DataCriacao
            // 
            this.DataCriacao.HeaderText = "DataCriacao";
            this.DataCriacao.MinimumWidth = 6;
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            this.DataCriacao.Width = 125;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 160);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(56, 22);
            this.textBoxId.TabIndex = 24;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 141);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(51, 16);
            this.labelId.TabIndex = 23;
            this.labelId.Text = "Código";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(77, 160);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(212, 22);
            this.textBoxDescricao.TabIndex = 26;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(77, 141);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(69, 16);
            this.labelDescricao.TabIndex = 25;
            this.labelDescricao.Text = "Descrição";
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(295, 160);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(97, 22);
            this.textBoxDesconto.TabIndex = 28;
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Location = new System.Drawing.Point(295, 141);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(65, 16);
            this.labelDesconto.TabIndex = 27;
            this.labelDesconto.Text = "Desconto";
            // 
            // buttonAdiciona
            // 
            this.buttonAdiciona.Location = new System.Drawing.Point(398, 160);
            this.buttonAdiciona.Name = "buttonAdiciona";
            this.buttonAdiciona.Size = new System.Drawing.Size(75, 23);
            this.buttonAdiciona.TabIndex = 29;
            this.buttonAdiciona.Text = "Adiciona";
            this.buttonAdiciona.UseVisualStyleBackColor = true;
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(479, 160);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 30;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            // 
            // CadastroOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAdiciona);
            this.Controls.Add(this.textBoxDesconto);
            this.Controls.Add(this.labelDesconto);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.ItemOrcamentoGridView);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.maskedTextBoxTelefone2);
            this.Controls.Add(this.labelTelefone2);
            this.Controls.Add(this.maskedTextBoxTelefone1);
            this.Controls.Add(this.labelTelefone1);
            this.Controls.Add(this.maskedTextBoxCPFCNPJ);
            this.Controls.Add(this.labelCPFCNPJ);
            this.Controls.Add(this.radioButtonCNPJ);
            this.Controls.Add(this.radioButtonCPF);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroOrcamento";
            this.Text = "CadastroOrcamento";
            ((System.ComponentModel.ISupportInitialize)(this.ItemOrcamentoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.RadioButton radioButtonCNPJ;
        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPFCNPJ;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone1;
        private System.Windows.Forms.Label labelTelefone1;
        private System.Windows.Forms.Label labelTelefone2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.DataGridView ItemOrcamentoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoInscricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.Button buttonAdiciona;
        private System.Windows.Forms.Button buttonDeletar;
    }
}