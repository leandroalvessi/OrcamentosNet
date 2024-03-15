using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosNet.Models
{
    public class PdfCabecalhoRodape : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            // Cabeçalho
            PdfPTable headerTbl = new PdfPTable(1);
            headerTbl.TotalWidth = document.PageSize.Width;

            PdfPCell headerCell = new PdfPCell(new Phrase("Cabeçalho do Documento"));
            headerCell.Border = 0;
            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;

            headerTbl.AddCell(headerCell);
            headerTbl.WriteSelectedRows(0, -1, 0, document.PageSize.Height - 10, writer.DirectContent);

            // Rodapé
            PdfPTable footerTbl = new PdfPTable(1);
            footerTbl.TotalWidth = document.PageSize.Width;

            PdfPCell footerCell = new PdfPCell(new Phrase("Rodapé do Documento"));
            footerCell.Border = 0;
            footerCell.HorizontalAlignment = Element.ALIGN_CENTER;

            footerTbl.AddCell(footerCell);
            footerTbl.WriteSelectedRows(0, -1, 0, 30, writer.DirectContent);
        }
    }
}
