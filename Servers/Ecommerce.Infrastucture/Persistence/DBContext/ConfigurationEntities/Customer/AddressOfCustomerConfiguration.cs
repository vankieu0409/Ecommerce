using Ecommerce.Domain.Entities.Author;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Customer;

public class AddressOfCustomerConfiguration : IEntityTypeConfiguration<AddressOfCustomer>
{
    public void Configure(EntityTypeBuilder<AddressOfCustomer> builder)
    {
        builder.ToTable("ADDRESS_CUSTOMER");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => c.Id);
        builder.HasOne<Domain.Entities.Author.Customer>(p => p.Customer).WithMany(c => c.AddressOfCustomers)
            .HasForeignKey(c => c.CustomerId).OnDelete(DeleteBehavior.Cascade);
    }
}