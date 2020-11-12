using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_vendas
{

    class atualizarProduto
    {
        sisVendasContext dbContext = new sisVendasContext();

        public void attProduto(Produto produto, string nome, double valor, string categoria)
        {
            var product = dbContext.Produto.Where(p => p.Nome == produto.Nome).First();

            product.Nome = nome;
            product.Valor = valor;
            product.Categoria = dbContext.Categoria.Where(c => c.Nome == categoria).First();

            dbContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();

        }

    }
}
