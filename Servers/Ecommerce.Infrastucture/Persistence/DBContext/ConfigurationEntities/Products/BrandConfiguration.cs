using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("BRANDS");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.BrandName, c.Id });
        builder.HasMany<Domain.Entities.Products.Products>(p => p.Products).WithOne(c => c.Brand)
            .HasForeignKey(c => c.IdBrand).OnDelete(DeleteBehavior.Cascade);
    }
}