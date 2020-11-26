using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace sis_vendas.Model
{
    class logadouroModelConfig : EntityTypeConfiguration<Logadouro>
    {
        public logadouroModelConfig()
        {
            HasKey(k => k.LogadouroId);
            Property(p => p.Cep).HasMaxLength(9).IsRequired();
            Property(p => p.Endereco).HasMaxLength(70).IsRequired();
            Property(p => p.Numero).IsRequired();
            this.HasRequired(p => p.bairro).WithMany().HasForeignKey(p => p.BairroId);
            this.HasRequired(p => p.cidade).WithMany().HasForeignKey(p => p.CidadeId);
            this.HasRequired(p => p.estado).WithMany().HasForeignKey(p => p.EstadoId);
        }
    }
}
