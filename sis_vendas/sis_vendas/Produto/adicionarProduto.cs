using System;
using System.Linq;


namespace sis_vendas
{
    class adicionarProduto
    {
        sisVendasContext dbContext = new sisVendasContext();
        Produto produto = new Produto();

        public void adicionarProdutoes(string nome,string categoria, double valor, int qtd)
        {

            produto.Nome = nome;
            produto.Categoria = dbContext.Categoria.Where(c => c.Nome == categoria).First();
            produto.Valor = valor;
            produto.dataCadastro = DateTime.Now.ToShortDateString();

            

            if (!String.IsNullOrEmpty(nome))
            {
                dbContext.Produto.Add(produto);
                dbContext.SaveChanges();
            }

        }
    }
}
