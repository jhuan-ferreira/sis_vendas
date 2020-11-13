using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_vendas
{
    class crudProduto
    {

        sisVendasContext dbContext = new sisVendasContext();
        Produto produto = new Produto();

        public void adicionaProduto(string nome, string categoria, decimal valor, int qtd)
        {

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrWhiteSpace(nome))
            {
                produto.Nome = nome;

            }

            else
            {
                return;
            }

            double numero;

            bool result = double.TryParse(Convert.ToString(valor), out numero);

            if (result)
            {
                produto.Valor = valor;
            }

            else
            {
                return;
            }

            if (!string.IsNullOrEmpty(categoria) && !string.IsNullOrWhiteSpace(categoria))
            {
                produto.Categoria = dbContext.Categoria.Where(c => c.Nome == categoria).First();
            }

            else
            {
                return;
            }

            produto.dataCadastro = DateTime.Now.ToShortDateString();

            dbContext.Produto.Add(produto);
            dbContext.SaveChanges();

        }

        public void atualizaProduto(Produto produto, string nome, decimal valor, string categoria)
        {
            var product = dbContext.Produto.Where(p => p.Nome == produto.Nome).First();

            product.Nome = nome;
            product.Valor = valor;
            product.Categoria = dbContext.Categoria.Where(c => c.Nome == categoria).First();

            dbContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();

        }

        public void removerProduto(int id)
        {
            var produto = dbContext.Produto.Where(p => p.Id == id).First();

            dbContext.Produto.Remove(produto);

            dbContext.SaveChanges();
        }

    }
}
