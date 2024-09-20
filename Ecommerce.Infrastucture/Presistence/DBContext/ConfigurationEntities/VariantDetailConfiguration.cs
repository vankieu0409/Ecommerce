using Ecommerce.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Presistence.DBContext.ConfigurationEntities;

public class VariantDetailConfiguration : IEntityTypeConfiguration<VariantDetail>
{
    public void Configure(EntityTypeBuilder<VariantDetail> builder)
    {
        builder.ToTable("VARIANT_DETAILS");
        builder.HasKey(c => new { c.IdVariant, c.IdOption, c.IdValue });
        builder.HasOne(c => c.IdVariantNavigation).WithMany(c => c.VariantDetails).HasForeignKey(c => c.IdVariant).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(c => c.IdOptionNavigation).WithMany(c => c.VariantDetails).HasForeignKey(c => c.IdOption).OnDelete(DeleteBehavior.NoAction);
        builder.HasOne(c => c.IdValueNavigation).WithMany(c => c.VariantDetails).HasForeignKey(c => c.IdValue).OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(c => new { c.IdVariant, c.IdOption, c.IdValue });
    }
}