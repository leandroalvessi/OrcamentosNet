using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using PdfDocument = PdfiumViewer.PdfDocument;
using System.IO;

namespace OrcamentosNet
{
    public partial class VisualizarPdf : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public VisualizarPdf(string filePath)
        {
            InitializeComponent();
            // Definir o tamanho do formulário para preencher a tela inteira
            this.WindowState = FormWindowState.Maximized;

            // Criar e configurar o PdfViewer
            pdf = new PdfViewer();
            pdf.Dock = DockStyle.Fill;

            // Adicionar o PdfViewer ao formulário
            this.Controls.Add(pdf);

            // Carregar e exibir o PDF
            CarregarPDF(filePath);
        }

        private void CarregarPDF(string filePath)
        {
            try
            {
                // Ler o arquivo PDF em um array de bytes
                byte[] bytes = File.ReadAllBytes(filePath);

                // Criar um MemoryStream a partir do array de bytes
                using (MemoryStream stream = new MemoryStream(bytes))
                {
                    // Carregar o documento PDF a partir do MemoryStream
                    PdfDocument pdfDocument = PdfDocument.Load(stream);

                    // Exibir o documento PDF no PdfViewer
                    pdf.Document = pdfDocument;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar o PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
