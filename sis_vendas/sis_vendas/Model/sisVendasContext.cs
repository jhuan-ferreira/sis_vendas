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
        public DbSet <VendaDetalhe> VendaDetalhe { get; set; }
        public DbSet <Produto> Produtos{ get; set; }
        public DbSet <Cliente> Clientes { get; set; }
        public DbSet <Categoria> Categorias { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet <Cidade> Cidades { get; set; }
        public DbSet <Estado> Estados { get; set; }
        public DbSet <Logadouro> logadouros{ get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new produtoConfigModel());
            modelBuilder.Configurations.Add(new clienteConfigModel());
            modelBuilder.Configurations.Add(new estadoConfigModel());
            modelBuilder.Configurations.Add(new cidadeConfigModel());
            modelBuilder.Configurations.Add(new bairroModelConfig());
            modelBuilder.Configurations.Add(new logadouroModelConfig());
        }

    }
}
