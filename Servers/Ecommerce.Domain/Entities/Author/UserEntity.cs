using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Author;

public class UserEntity : EntityBase<Guid>
{
    public string DisplayName { get; set; }
    public string? Decriptions { get; set; }
    public string? Image { get; set; }
    public string? Address { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string PhoneNumber { get; set; }

    public Guid RoleId { get; set; }
    public RoleEntity Role { get; set; }

}