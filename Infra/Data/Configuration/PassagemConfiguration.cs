using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Configuration;

public class PassagemConfiguration : IEntityTypeConfiguration<Passagem>
{
    public void Configure(EntityTypeBuilder<Passagem> builder)
    {
        builder.HasKey(p => p.PassagemID);
        builder.Property(p => p.PrecoTotal).IsRequired();

        // Relacionamento com Voo
        builder.HasOne(p => p.Voo)
               .WithMany()
               .HasForeignKey(p => p.VooID)
               .IsRequired();

        // Relacionamento com Classe
        builder.HasOne(p => p.Classe)
               .WithMany()
               .HasForeignKey(p => p.ClasseID)
               .IsRequired();

        // Relacionamento com Passageiro
        builder.HasOne(p => p.Passageiro)
               .WithMany()
               .HasForeignKey(p => p.PassageiroID)
               .IsRequired();
    }
}