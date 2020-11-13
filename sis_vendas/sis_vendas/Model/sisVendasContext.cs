using System.Data.Entity;
using sis_vendas.Model;

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

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new produtoConfigModel());
            modelBuilder.Configurations.Add(new clienteConfigModel());

                
        }

    }
}
