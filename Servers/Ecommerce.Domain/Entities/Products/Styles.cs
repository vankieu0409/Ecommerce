using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Products;

public class Styles : FullAuditedEntity<Guid>
{
    public string Style { get; set; } // Loại Chất Liệu
    public string Detail { get; set; } // Chi tiết
    public List<Products> Products { get; set; }
}