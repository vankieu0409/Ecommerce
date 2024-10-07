using Ecommerce.Domain.Entities.Orders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
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


        builder.HasOne(oi => oi.Order)
               .WithMany(o => o.OrderItems)
               .HasForeignKey(oi => oi.OrderId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(oi => oi.Variant)
               .WithMany()
               .HasForeignKey(oi => oi.VariantId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(oi => new { oi.OrderId, oi.VariantId })
               .IsUnique();
    }
}