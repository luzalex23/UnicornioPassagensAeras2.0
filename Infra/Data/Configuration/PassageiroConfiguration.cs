using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Configuration;

public class PassageiroConfiguration : IEntityTypeConfiguration<Passageiro>
{
    public void Configure(EntityTypeBuilder<Passageiro> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Cpf).IsRequired();
        builder.Property(p => p.idade).IsRequired();
        builder.Property(p => p.Dtnascimento).IsRequired();
    }
}
