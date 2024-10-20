using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Products;

public class Category : FullAuditedEntity<Guid>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<Products> Products { get; set; }
}