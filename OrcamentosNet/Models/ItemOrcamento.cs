using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentosNet.Models
{
    internal class ItemOrcamento
    {
        public int IdOrcamento { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }

        public ItemOrcamento(int idOrcamento = 0, int idProduto = 0, int quantidade = 0)
        {
            IdOrcamento = idOrcamento;
            IdProduto = idProduto;
            Quantidade = quantidade;
        }
    }
}
