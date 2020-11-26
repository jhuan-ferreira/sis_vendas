using System.Data.Entity.ModelConfiguration;

namespace sis_vendas
{
    class produtoConfigModel : EntityTypeConfiguration<Produto>
    {
        public produtoConfigModel()
        {
            this.HasKey(k => k.ProdutoId);
            this.Property(p => p.Nome).HasMaxLength(60).IsRequired();
            this.Property(p => p.Valor).IsRequired();
            this.Property(p => p.categoriaId).IsRequired();

        }


    }       
}
