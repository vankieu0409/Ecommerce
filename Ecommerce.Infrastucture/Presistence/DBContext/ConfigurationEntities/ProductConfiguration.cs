using Ecommerce.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Presistence.DBContext.ConfigurationEntities;

public class ProductConfiguration : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> builder)
    {
        builder.ToTable("PRODUCTS");
        builder.HasKey(e => e.Id);
        builder.HasMany(c => c.Variants).WithOne(c => c.IdProductNavigation).HasForeignKey(c => c.IdProduct).OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(c => new { c.ProductName, c.Id });
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.ProductName).IsRequired();
        builder.Property(c => c.Description);
    }
}