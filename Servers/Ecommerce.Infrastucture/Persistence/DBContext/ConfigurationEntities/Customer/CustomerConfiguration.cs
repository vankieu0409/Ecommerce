using Ecommerce.Domain.Entities.Orders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Customer;

public class CustomerConfiguration : IEntityTypeConfiguration<Domain.Entities.Author.Customer>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Author.Customer> builder)
    {
        builder.ToTable("CUSTOMERS");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.IdRole, c.FullName, c.Id });
        builder.HasMany<Order>(p => p.Orders).WithOne(c => c.Customer)
            .HasForeignKey(c => c.CustomerId).OnDelete(DeleteBehavior.Restrict);
    }
}