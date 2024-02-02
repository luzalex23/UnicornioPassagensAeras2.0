﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Configuration;

public class CodigoIataConfiguration : IEntityTypeConfiguration<Iata>
{
    public void Configure(EntityTypeBuilder<Iata> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Name).IsRequired();
        builder.Property(i => i.CreatedDate);
    }
}
