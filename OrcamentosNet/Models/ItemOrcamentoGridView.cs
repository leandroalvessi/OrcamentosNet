using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosNet.Models
{
    internal class ItemOrcamentoGridView
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

        public ItemOrcamentoGridView(int id = 0, string descricao = "", int quantidade = 0, decimal valor = 0)
        {
            Id = id;
            Descricao = descricao;
            Quantidade = quantidade;
            Valor = valor;
        }
    }
}
