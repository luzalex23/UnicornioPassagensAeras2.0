using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Configuration;

public class CompraConfiguration : IEntityTypeConfiguration<Compra>
{
    public void Configure(EntityTypeBuilder<Compra> builder)
    {
        builder.HasKey(c => c.CompraID);
        builder.Property(c => c.QuantidadePassagens).IsRequired();
        builder.Property(c => c.CompraDate).IsRequired();
        builder.HasOne(c => c.Passageiro).WithMany().HasForeignKey(c => c.PassageiroID);
        builder.HasOne(c => c.Voo).WithMany().HasForeignKey(c => c.VooID);
        builder.HasOne(c => c.Classe).WithMany().HasForeignKey(c => c.ClasseID);
    }
}
