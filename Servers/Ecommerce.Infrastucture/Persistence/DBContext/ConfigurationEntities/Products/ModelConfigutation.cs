﻿using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class ModelConfigutation : IEntityTypeConfiguration<ModelTypes>
{
    public void Configure(EntityTypeBuilder<ModelTypes> builder)
    {
        builder.ToTable("MODELTYPE");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.ModelType, c.Id });
        builder.HasMany<Domain.Entities.Products.Products>(p => p.Products).WithOne(c => c.ModelType)
            .HasForeignKey(c => c.IdModel);
        //.OnDelete(DeleteBehavior.Cascade);
    }
}
