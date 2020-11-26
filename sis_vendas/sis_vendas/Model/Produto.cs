using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sis_vendas
{
   public class Produto
    {
        
        //[ForeignKey("ProdutoId")]
        
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int categoriaId { get; set; }
        public string dataCadastro { get; set; }

        public Categoria Categoria { get; set; }


    }
}
