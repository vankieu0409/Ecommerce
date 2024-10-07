using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities;

public class ProductConfiguration : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> builder)
    {
        builder.ToTable("PRODUCTS");
        builder.HasKey(e => e.Id);
        builder.HasMany(c => c.Variants).WithOne().HasForeignKey(c => c.IdProduct).OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(c => new { c.Name, c.Id });
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Name).IsRequired();
        builder.Property(c => c.Description); builder.Property(c => c.Images).HasConversion(
            v => string.Join(',', v),
            v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
        ).HasColumnType("nvarchar(max)");
    }
}
