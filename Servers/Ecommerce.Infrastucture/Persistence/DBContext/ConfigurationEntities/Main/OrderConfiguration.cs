using Ecommerce.Domain.Entities.Orders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Main;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("ORDERS");
        builder.HasKey(c => c.Id);
        builder.Property(o => o.CustomerId).IsRequired();
        builder.Property(o => o.EmployeeId).IsRequired();
        builder.Property(o => o.CreationDate).HasDefaultValue(DateTime.Now);
        builder.Property(o => o.Payments)
            .HasColumnType("decimal(18,2)")
            .IsRequired();
        builder.Property(o => o.Refund)
            .HasColumnType("decimal(18,2)")
            .IsRequired();
        builder.Property(o => o.TotalAmount)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.HasMany(o => o.OrderDetails)
            .WithOne()
            .HasForeignKey("OrderId")
            .OnDelete(DeleteBehavior.Restrict);

    }
}