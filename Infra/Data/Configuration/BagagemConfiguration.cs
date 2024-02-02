using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Configuration;

public class BagagemConfiguration : IEntityTypeConfiguration<Bagagem>
{
    public void Configure(EntityTypeBuilder<Bagagem> builder)
    {
        builder.HasKey(b => b.BagagemID);
        builder.HasOne(b => b.Passagem).WithMany().HasForeignKey(b => b.PassagemID);
    }
}
