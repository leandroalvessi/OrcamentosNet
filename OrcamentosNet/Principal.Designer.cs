namespace OrcamentosNet
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.buttonOrcamentos = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOrcamentos
            // 
            this.buttonOrcamentos.Location = new System.Drawing.Point(12, 12);
            this.buttonOrcamentos.Name = "buttonOrcamentos";
            this.buttonOrcamentos.Size = new System.Drawing.Size(150, 100);
            this.buttonOrcamentos.TabIndex = 0;
            this.buttonOrcamentos.Text = "Orçamentos";
            this.buttonOrcamentos.UseVisualStyleBackColor = true;
            this.buttonOrcamentos.Click += new System.EventHandler(this.buttonOrcamentos_Click);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.Location = new System.Drawing.Point(168, 12);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(150, 100);
            this.buttonProdutos.TabIndex = 1;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.UseVisualStyleBackColor = true;
            this.buttonProdutos.Click += new System.EventHandler(this.buttonProdutos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProdutos);
            this.Controls.Add(this.buttonOrcamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrcamentos;
        private System.Windows.Forms.Button buttonProdutos;
    }
}

