

namespace sis_vendas.Model
{
   public class Logadouro
    {
        public int LogadouroId { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
        public int BairroId { get; set; }
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }

        public virtual Bairro bairro { get; set; }
        public virtual Cidade cidade { get; set; }
        public virtual Estado estado { get; set; }
    }
}
