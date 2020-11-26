using System.Data.Entity.ModelConfiguration;

namespace sis_vendas.Model
{
    class cidadeConfigModel : EntityTypeConfiguration<Cidade>
    {
        public cidadeConfigModel()
        {
            HasKey(k => k.CidadeId);
            this.Property(p => p.Nome).HasMaxLength(70).IsRequired();
        }
    }
}
