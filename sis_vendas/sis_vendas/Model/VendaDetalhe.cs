

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
