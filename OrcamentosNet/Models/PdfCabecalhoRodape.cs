﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosNet.Models
{
    public class PdfCabecalhoRodape : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            string executableLocation = Assembly.GetExecutingAssembly().Location;
            string executableDirectory = Path.GetDirectoryName(executableLocation);
            string logoPath = Path.Combine(executableDirectory, "logo.png");

            // Cabeçalho
            PdfPTable headerTbl = new PdfPTable(1);
            headerTbl.TotalWidth = document.PageSize.Width;

            PdfPCell headerCell = new PdfPCell(new Phrase("Orçamento Net"));
            headerCell.Border = 0;
            headerCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            headerCell.PaddingRight = 30;

            // Adicione o logo ao cabeçalho
            Image logo = Image.GetInstance(logoPath);
            logo.ScaleToFit(100, 100);
            logo.BackgroundColor = BaseColor.WHITE; // Define o fundo como branco (substitua pelo fundo desejado)
            PdfPCell logoCell = new PdfPCell(logo);
            logoCell.Border = 0;
            logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
            logoCell.PaddingLeft = 30;

            headerTbl.AddCell(headerCell);
            headerTbl.AddCell(logoCell);
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
