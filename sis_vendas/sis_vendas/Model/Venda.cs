using System;
using System.Collections.Generic;

namespace sis_vendas
{
   public class Venda
    {
        public int vendaId { get; set; }
        public int clienteId { get; set; }
        public DateTime Data { get; set; }
        public double valorTotal { get; set; }

        public List<VendaDetalhe> vendaDetalhe { get; set; }

    }
}
