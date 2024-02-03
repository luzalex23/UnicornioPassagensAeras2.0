using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Configuration;

public class ClasseConfiguration : IEntityTypeConfiguration<Classe>

{
    public void Configure(EntityTypeBuilder<Classe> builder)
{
    builder.HasKey(c => c.Id);
    builder.Property(c => c.TipoClasse).IsRequired();
    builder.Property(c => c.QuantidadeAssentos).IsRequired();
    builder.Property(c => c.ValorAssento).IsRequired();

    // Relacionamento com Voo
    builder.HasOne(c => c.Voo)
           .WithMany(v => v.Classes)
           .HasForeignKey(c => c.VooID)
           .IsRequired();
}
}