using Ecommerce.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Presistence.DBContext.ConfigurationEntities;

public class VariantConfiguration : IEntityTypeConfiguration<Variants>
{
    public void Configure(EntityTypeBuilder<Variants> builder)
    {
        builder.ToTable("VARIANTS");
        builder.HasKey(c => c.Id);
        builder.HasOne(c => c.IdProductNavigation).WithMany(c => c.Variants).HasForeignKey(c => c.IdProduct).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(c => c.VariantDetails).WithOne(c => c.IdVariantNavigation).HasForeignKey(c => c.IdVariant).OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(c => new { c.IdProduct, c.Id });

        builder.Property(c => c.IdProduct).IsRequired();
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Price);
        builder.Property(c => c.Images).HasConversion(v => string.Join(',', v), v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()).HasColumnType("nvarchar(max)");
        builder.Property(c => c.Quantity);
    }
}