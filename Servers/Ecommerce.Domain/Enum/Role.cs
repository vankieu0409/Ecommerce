using System.ComponentModel;

namespace Ecommerce.Domain.Enum;

public enum Role
{
    [Description("Admin")]
    Admin,
    [Description("Customer")]
    Customer,
    [Description("Employee")]
    Employee
}