using Ecommerce.Domain.Entities.Orders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Main;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.ToTable("ORDER_ITEMS");
        builder.HasKey(oi => oi.Id);

        builder.Property(oi => oi.Quantity)
               .IsRequired();

        builder.Property(oi => oi.UnitPrice)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(oi => oi.TotalPrice)
               .IsRequired()
               .HasColumnType("decimal(18,2)");

        builder.HasIndex(oi => new { oi.OrderId, oi.VariantId })
               .IsUnique();
        builder.HasOne(p => p.Variant)
               .WithMany(v => v.OrderDetails)
               .HasForeignKey(oi => oi.OrderId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}