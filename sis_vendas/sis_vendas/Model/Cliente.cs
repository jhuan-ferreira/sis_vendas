

namespace sis_vendas
{
   public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Endereço { get; set; }

        public int vendasDetalheId { get; set; }
    }
}
