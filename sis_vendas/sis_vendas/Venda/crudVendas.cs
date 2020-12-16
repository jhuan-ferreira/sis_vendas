using System;
using System.Linq;
using System.Windows.Forms;

namespace sis_vendas
{
    class crudVendas
    {
        sisVendasContext dbContext = new sisVendasContext();

        public void efetivaVenda( DataGridView dgv, double total, decimal valorFrete, Cliente cliente)
        {
            Produto produto = new Produto();

            Venda venda = new Venda();
            VendaDetalhe vendaDetalhe = new VendaDetalhe();

            venda.Data = Convert.ToString(DateTime.Now.Date);
            venda.ValorTotal = total;
            venda.ValorFrete = valorFrete;
            venda.ClienteId = cliente.ClienteId;

            dbContext.Vendas.Add(venda);

            produto = null;

            dbContext.SaveChanges();

            int count = dgv.Rows.Count;

            int i = 0;

            while (i <= count - 1)
            {
                int id = int.Parse(dgv.Rows[i].Cells[0].Value.ToString());

                
                vendaDetalhe.Quantidade = int.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                vendaDetalhe.ValorUnitario = decimal.Parse(dgv.Rows[i].Cells[2].Value.ToString().Replace("R$", ""));
                vendaDetalhe.ProdutoId = dbContext.Produtos.Where(p => p.ProdutoId == id).Select(p => p.ProdutoId).First();
                vendaDetalhe.VendaId = dbContext.Vendas.Where(p => p.VendaId == venda.VendaId).Select(p => p.VendaId).First();

                dbContext.VendaDetalhe.Add(vendaDetalhe);

                dbContext.SaveChanges();

                i++;
            }

        }



    }
}
