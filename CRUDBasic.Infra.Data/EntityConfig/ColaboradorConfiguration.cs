using CRUDBasic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBasic.Infra.Data.EntityConfig
{
    public class ColaboradorConfiguration : EntityTypeConfiguration<Colaborador>
    {
        public ColaboradorConfiguration()
        {
            HasKey(c => c.ColaboradorId);

            Property(c => c.Nome)                
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Pis)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.Observacao)
                .IsRequired()
                .HasMaxLength(300);

            Property(c => c.Passaporte)
                .IsRequired()
                .HasMaxLength(20);

            Property(c => c.RG)
                .IsRequired()
                .HasMaxLength(20);

            Property(c => c.Sexo)
                .HasMaxLength(1);
        }
    }
}
