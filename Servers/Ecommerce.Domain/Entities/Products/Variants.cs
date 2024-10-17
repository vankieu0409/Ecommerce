using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Products;
public class Variants : FullAuditedEntity<Guid>
{
    public Guid IdProduct { get; set; }
    public Guid IdColor { get; set; }
    public Guid IdSize { get; set; }
    public int Quantity { get; set; }

    //navigation

    public List<Images> Images { get; set; }
    public Sizes Sizes { get; set; }
    public Colors Colors { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}