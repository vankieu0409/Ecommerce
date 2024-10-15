using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class ProductConfiguration : IEntityTypeConfiguration<Domain.Entities.Products.Products>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Products.Products> builder)
    {
        builder.ToTable("PRODUCTS");
        builder.HasKey(e => e.Id);
        builder.HasMany(c => c.Variants).WithOne().HasForeignKey(c => c.IdProduct).OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(c => new { c.Name, c.Id });
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Name).IsRequired();

    }
}
