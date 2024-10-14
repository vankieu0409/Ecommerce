using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class ImageConfiguration : IEntityTypeConfiguration<Images>
{
    public void Configure(EntityTypeBuilder<Images> builder)
    {
        builder.ToTable("IMAGES");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.Id });
        builder.HasOne<Variants>(p => p.Variants).WithMany(c => c.Images)
            .HasForeignKey(c => c.IdVariant).OnDelete(DeleteBehavior.Cascade);
    }
}