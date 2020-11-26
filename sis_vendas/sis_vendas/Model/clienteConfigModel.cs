
using System.Data.Entity.ModelConfiguration;

namespace sis_vendas.Model
{
    class clienteConfigModel : EntityTypeConfiguration<Cliente>
    {
        public clienteConfigModel()
        {
            this.HasKey(k => k.ClienteId);
            this.Property(p => p.Documento).HasMaxLength(15).IsRequired();
            this.Property(p => p.Email).HasMaxLength(70).IsOptional();
            this.Property(p => p.Tel).HasMaxLength(14).IsRequired();
            this.Property(p => p. Nome).HasMaxLength(70).IsRequired();
            this.Property(p => p.enderecoId).IsOptional();
        }
    }
}
