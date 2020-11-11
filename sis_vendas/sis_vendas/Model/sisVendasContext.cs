using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace sis_vendas
{
    public class sisVendasContext : DbContext
    {
        
        public sisVendasContext()
            : base(@"Data Source=DESKTOP-LNCG385\SQLDBSS;Initial Catalog=Sis_Vendas;Integrated Security=True")
        {
          
        }

        public DbSet<Venda> Vendas {get; set;}
        public DbSet <VendaDetalhe> vendaDetalhe { get; set; }
        public DbSet <Produto> Produto{ get; set; }
        public DbSet <Cliente> Cliente { get; set; }
        public DbSet <Categoria> Categoria { get; set; }

    }
}
