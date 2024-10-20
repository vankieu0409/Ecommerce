using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Products;

public class Materials : FullAuditedEntity<Guid>
{
    public string MaterialType { get; set; } // Loại Chất Liệu
    public string Detail { get; set; } // Chi tiết
    public List<Products> Products { get; set; }
}