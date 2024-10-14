using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class MaterialConfiguration : IEntityTypeConfiguration<Materials>
{

    public void Configure(EntityTypeBuilder<Materials> builder)
    {
        builder.ToTable("MATERIALS");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.MaterialType, c.Id });
        builder.HasMany<Domain.Entities.Products.Products>(p => p.Products).WithOne(c => c.Material)
            .HasForeignKey(c => c.IdMaterial).OnDelete(DeleteBehavior.Cascade);
    }
}