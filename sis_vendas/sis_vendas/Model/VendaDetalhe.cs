using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_vendas
{
   public class VendaDetalhe
    {
        public int vendaDetalheId { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public double Valor { get; set; }
         
    }
}
