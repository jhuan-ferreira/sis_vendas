using System;

namespace sis_vendas
{
   public class Venda
    {        
        public int VendaId { get; set; }
        public int ClienteId { get; set; }
        public string Data { get; set; }
        public double ValorTotal { get; set; }
        public decimal ValorFrete  { get; set; }


    }
}
