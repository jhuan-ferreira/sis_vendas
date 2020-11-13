using System.Collections.Generic;

namespace sis_vendas
{
   public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int categoriaId { get; set; }
        public string dataCadastro { get; set; }

        public Categoria Categoria { get; set; }

        public virtual List<Venda> Vendas { get; set; }

    }
}
