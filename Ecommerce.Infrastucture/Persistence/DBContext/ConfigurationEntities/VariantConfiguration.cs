﻿using Ecommerce.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Presistence.DBContext.ConfigurationEntities;

public class VariantConfiguration : IEntityTypeConfiguration<Variants>
{
    public void Configure(EntityTypeBuilder<Variants> builder)
    {
        builder.ToTable("VARIANTS");
        builder.HasKey(c => c.Id);

        builder.HasIndex(c => new { c.IdProduct, c.Id });

        builder.Property(c => c.IdProduct).IsRequired();
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Price);
        builder.Property(c => c.Quantity);
    }
}