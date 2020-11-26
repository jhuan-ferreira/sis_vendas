using System.Data.Entity.ModelConfiguration;

namespace sis_vendas.Model
{
    class estadoConfigModel : EntityTypeConfiguration<Estado>
    {
        public estadoConfigModel()
        {
            HasKey(k => k.EstadoId);
            this.Property(p => p.Nome).HasMaxLength(70).IsRequired();
        }
    }
}
