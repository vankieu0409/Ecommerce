using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public class Category :EntityBase<Guid>
{
    public string Name { get; set; } 
    public string? Description { get; set; } 
    public DateTime CreatedDate { get; set; } 
    public DateTime UpdatedDate { get; set; } 
    public bool IsActive { get; set; } 
}