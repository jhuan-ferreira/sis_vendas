using sis_vendas.Model;

namespace sis_vendas
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Documento { get; set; }
        public int enderecoId { get; set; }

        public int vendasDetalheId { get; set; }

    }
}
