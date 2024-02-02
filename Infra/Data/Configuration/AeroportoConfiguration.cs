using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Configuration;

public class AeroportoConfiguration : IEntityTypeConfiguration<Aeroporto>
{
    public void Configure(EntityTypeBuilder<Aeroporto> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.CodigoIATA).IsRequired();
        builder.Property(a => a.Name).IsRequired();
        builder.HasOne(a => a.Cidade).WithMany().HasForeignKey(a => a.CidadeID);
        builder.HasOne(a => a.Iata).WithMany().HasForeignKey(a => a.IataID);

    }
}
