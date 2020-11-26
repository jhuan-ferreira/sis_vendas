using System;
using System.Linq;
using System.Windows.Forms;

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
                produto.Categoria = dbContext.Categorias.Where(c => c.Nome == categoria).First();
            }

            else
            {
                return;
            }

            produto.dataCadastro = DateTime.Now.ToShortDateString();

            dbContext.Produtos.Add(produto);
            dbContext.SaveChanges();

        }

        public void atualizaProduto(Produto produto, string nome, decimal valor, string categoria)
        {
            var product = dbContext.Produtos.Where(p => p.Nome == produto.Nome).First();

            product.Nome = nome;
            product.Valor = valor;
            product.Categoria = dbContext.Categorias.Where(c => c.Nome == categoria).First();

            dbContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();

        }

        public void removerProduto(int id)
        {
            var produto = dbContext.Produtos.Where(p => p.ProdutoId == id).First();

            dbContext.Produtos.Remove(produto);

            dbContext.SaveChanges();
        }


        public void preencheDgv(DataGridView dgv)
        {
            var index = dgv.Rows.Add();


            dgv.Rows[index].Cells[0].Value = produto.ProdutoId;
            dgv.Rows[index].Cells[1].Value = produto.Nome;
            dgv.Rows[index].Cells[2].Value = dbContext.Categorias.Where(p => p.categoriaId == produto.categoriaId).Select(p => p.Nome).First();
            dgv.Rows[index].Cells[3].Value = produto.Valor;
        }


    }
}
