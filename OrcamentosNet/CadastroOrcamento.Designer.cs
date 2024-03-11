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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxUF = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.maskedTextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.buttonAdiciona = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.textBoxTotalGeral = new System.Windows.Forms.TextBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.labelBairro = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
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
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Location = new System.Drawing.Point(12, 28);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(315, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.Location = new System.Drawing.Point(342, 30);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(54, 20);
            this.radioButtonCPF.TabIndex = 2;
            this.radioButtonCPF.TabStop = true;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
            this.radioButtonCPF.CheckedChanged += new System.EventHandler(this.radioButtonCPF_CheckedChanged);
            // 
            // radioButtonCNPJ
            // 
            this.radioButtonCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCNPJ.AutoSize = true;
            this.radioButtonCNPJ.Location = new System.Drawing.Point(396, 30);
            this.radioButtonCNPJ.Name = "radioButtonCNPJ";
            this.radioButtonCNPJ.Size = new System.Drawing.Size(63, 20);
            this.radioButtonCNPJ.TabIndex = 3;
            this.radioButtonCNPJ.TabStop = true;
            this.radioButtonCNPJ.Text = "CNPJ";
            this.radioButtonCNPJ.UseVisualStyleBackColor = true;
            this.radioButtonCNPJ.CheckedChanged += new System.EventHandler(this.radioButtonCNPJ_CheckedChanged);
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(459, 4);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(68, 16);
            this.labelCPFCNPJ.TabIndex = 4;
            this.labelCPFCNPJ.Text = "CPFCNPJ";
            // 
            // maskedTextBoxCPFCNPJ
            // 
            this.maskedTextBoxCPFCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCPFCNPJ.Location = new System.Drawing.Point(462, 27);
            this.maskedTextBoxCPFCNPJ.Mask = "000,000,000-00";
            this.maskedTextBoxCPFCNPJ.Name = "maskedTextBoxCPFCNPJ";
            this.maskedTextBoxCPFCNPJ.Size = new System.Drawing.Size(146, 22);
            this.maskedTextBoxCPFCNPJ.TabIndex = 5;
            // 
            // maskedTextBoxTelefone1
            // 
            this.maskedTextBoxTelefone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxTelefone1.Location = new System.Drawing.Point(614, 27);
            this.maskedTextBoxTelefone1.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxTelefone1.Name = "maskedTextBoxTelefone1";
            this.maskedTextBoxTelefone1.Size = new System.Drawing.Size(120, 22);
            this.maskedTextBoxTelefone1.TabIndex = 7;
            // 
            // labelTelefone1
            // 
            this.labelTelefone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTelefone1.AutoSize = true;
            this.labelTelefone1.Location = new System.Drawing.Point(611, 5);
            this.labelTelefone1.Name = "labelTelefone1";
            this.labelTelefone1.Size = new System.Drawing.Size(71, 16);
            this.labelTelefone1.TabIndex = 6;
            this.labelTelefone1.Text = "Telefone 1";
            // 
            // labelTelefone2
            // 
            this.labelTelefone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTelefone2.AutoSize = true;
            this.labelTelefone2.Location = new System.Drawing.Point(737, 4);
            this.labelTelefone2.Name = "labelTelefone2";
            this.labelTelefone2.Size = new System.Drawing.Size(71, 16);
            this.labelTelefone2.TabIndex = 8;
            this.labelTelefone2.Text = "Telefone 2";
            // 
            // maskedTextBoxTelefone2
            // 
            this.maskedTextBoxTelefone2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxTelefone2.Location = new System.Drawing.Point(740, 27);
            this.maskedTextBoxTelefone2.Mask = "(99) 0 0000-0000";
            this.maskedTextBoxTelefone2.Name = "maskedTextBoxTelefone2";
            this.maskedTextBoxTelefone2.Size = new System.Drawing.Size(120, 22);
            this.maskedTextBoxTelefone2.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(12, 72);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(315, 22);
            this.textBoxEmail.TabIndex = 11;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 53);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 16);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "E-Mail";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEndereco.Location = new System.Drawing.Point(333, 72);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(359, 22);
            this.textBoxEndereco.TabIndex = 13;
            // 
            // labelEndereco
            // 
            this.labelEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(330, 53);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(66, 16);
            this.labelEndereco.TabIndex = 12;
            this.labelEndereco.Text = "Endereço";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBairro.Location = new System.Drawing.Point(698, 72);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(161, 22);
            this.textBoxBairro.TabIndex = 15;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(719, 422);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(38, 16);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "Total";
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
            this.labelUF.Size = new System.Drawing.Size(25, 16);
            this.labelUF.TabIndex = 16;
            this.labelUF.Text = "UF";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCidade.Location = new System.Drawing.Point(74, 116);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(253, 22);
            this.textBoxCidade.TabIndex = 19;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(74, 97);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(51, 16);
            this.labelCidade.TabIndex = 18;
            this.labelCidade.Text = "Cidade";
            // 
            // maskedTextBoxCEP
            // 
            this.maskedTextBoxCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxCEP.Location = new System.Drawing.Point(333, 116);
            this.maskedTextBoxCEP.Mask = "00000-000";
            this.maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            this.maskedTextBoxCEP.Size = new System.Drawing.Size(126, 22);
            this.maskedTextBoxCEP.TabIndex = 21;
            // 
            // labelCEP
            // 
            this.labelCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(330, 97);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(34, 16);
            this.labelCEP.TabIndex = 20;
            this.labelCEP.Text = "CEP";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(12, 160);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(56, 22);
            this.textBoxId.TabIndex = 24;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
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
            this.textBoxDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescricao.Location = new System.Drawing.Point(77, 160);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.ReadOnly = true;
            this.textBoxDescricao.Size = new System.Drawing.Size(517, 22);
            this.textBoxDescricao.TabIndex = 26;
            this.textBoxDescricao.DoubleClick += new System.EventHandler(this.textBoxDescricao_DoubleClick);
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
            this.textBoxDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesconto.Location = new System.Drawing.Point(600, 160);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(97, 22);
            this.textBoxDesconto.TabIndex = 28;
            this.textBoxDesconto.Leave += new System.EventHandler(this.textBoxDesconto_Leave);
            // 
            // labelDesconto
            // 
            this.labelDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Location = new System.Drawing.Point(597, 141);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(65, 16);
            this.labelDesconto.TabIndex = 27;
            this.labelDesconto.Text = "Desconto";
            // 
            // buttonAdiciona
            // 
            this.buttonAdiciona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdiciona.Location = new System.Drawing.Point(703, 160);
            this.buttonAdiciona.Name = "buttonAdiciona";
            this.buttonAdiciona.Size = new System.Drawing.Size(75, 23);
            this.buttonAdiciona.TabIndex = 29;
            this.buttonAdiciona.Text = "Adiciona";
            this.buttonAdiciona.UseVisualStyleBackColor = true;
            this.buttonAdiciona.Click += new System.EventHandler(this.buttonAdiciona_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletar.Location = new System.Drawing.Point(784, 160);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletar.TabIndex = 30;
            this.buttonDeletar.Text = "Deletar";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // textBoxTotalGeral
            // 
            this.textBoxTotalGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalGeral.Location = new System.Drawing.Point(763, 416);
            this.textBoxTotalGeral.Name = "textBoxTotalGeral";
            this.textBoxTotalGeral.ReadOnly = true;
            this.textBoxTotalGeral.Size = new System.Drawing.Size(97, 22);
            this.textBoxTotalGeral.TabIndex = 31;
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalva.Location = new System.Drawing.Point(11, 388);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(100, 50);
            this.buttonSalva.TabIndex = 32;
            this.buttonSalva.Text = "Salvar";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // labelBairro
            // 
            this.labelBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(700, 53);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(43, 16);
            this.labelBairro.TabIndex = 33;
            this.labelBairro.Text = "Bairro";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Quantidade,
            this.Valor,
            this.Total});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(11, 189);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersVisible = false;
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.RowTemplate.Height = 24;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(848, 193);
            this.dataGridViewProdutos.TabIndex = 22;
            this.dataGridViewProdutos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellEndEdit);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 80;
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
            this.Valor.Width = 125;
            // 
            // Total
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // CadastroOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.textBoxTotalGeral);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonAdiciona);
            this.Controls.Add(this.textBoxDesconto);
            this.Controls.Add(this.labelDesconto);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.maskedTextBoxCEP);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxUF);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.labelTotal);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroOrcamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
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
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxUF;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCEP;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.Button buttonAdiciona;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.TextBox textBoxTotalGeral;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}