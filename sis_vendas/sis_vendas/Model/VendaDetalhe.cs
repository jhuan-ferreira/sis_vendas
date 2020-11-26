
namespace sis_vendas
{
    public class VendaDetalhe
    {
        public int VendaDetalheId { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
