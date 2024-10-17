using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Products;

public class Brand : FullAuditedEntity<Guid>
{
    public string BrandName { get; set; } // Tên thương hiệu
    public string Detail { get; set; } // Chi tiết
    public List<Products> Products { get; set; }
}