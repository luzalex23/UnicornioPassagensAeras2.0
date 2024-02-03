using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Configuration;

public class VooConfiguration : IEntityTypeConfiguration<Voo>
{
    public void Configure(EntityTypeBuilder<Voo> builder)
    {
        builder.HasKey(v => v.Id);
        builder.Property(v => v.DataHoraPartida).IsRequired();
        builder.HasOne(v => v.AeroportoOrigem).WithMany().HasForeignKey(v => v.AeroportoOrigemID);
        builder.HasOne(v => v.AeroportoDestino).WithMany().HasForeignKey(v => v.AeroportoDestinoID);
    }
}

