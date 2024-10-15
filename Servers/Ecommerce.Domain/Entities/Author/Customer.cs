using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Author;

public class Customer : EntityAuditBase<Guid>
{
    public Guid IdAddress { get; set; }
    public Guid IdRole { get; set; }
    public string PhoneNumber { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Image { get; set; }

    //navigation

    public virtual RoleEntity Role { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    public virtual ICollection<AddressOfCustomer> AddressOfCustomers { get; set; }
}