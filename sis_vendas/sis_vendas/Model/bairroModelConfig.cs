using System.Data.Entity.ModelConfiguration;

namespace sis_vendas.Model
{
    class bairroModelConfig : EntityTypeConfiguration<Bairro>
    {
        public bairroModelConfig()
        {
            HasKey(k => k.BairroId);
            this.Property(p => p.Nome).HasMaxLength(70).IsRequired();
        }
    }
}
