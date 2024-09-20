using Ecommerce.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Presistence.DBContext.ConfigurationEntities;

public class ValueConfiguration : IEntityTypeConfiguration<OptionValues>
{
    public void Configure(EntityTypeBuilder<OptionValues> builder)
    {
        builder.ToTable("OPTION_VALUES");
        builder.HasKey(c => new { c.Id });
        builder.HasOne(c => c.IdOptionNavigation).WithMany(c => c.OptionsValues).HasForeignKey(c => c.IdOption).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(c => c.VariantDetails).WithOne(c => c.IdValueNavigation).HasForeignKey(c => c.IdValue).OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(c => new { c.IdOption, c.Id, c.Value });

        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Value).IsRequired().HasMaxLength(200);

    }
}