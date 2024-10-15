using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;
public class Variants : EntityAuditBase<Guid>
{
    public Guid IdProduct { get; set; }
    public Guid IdColor { get; set; }
    public Guid IdSize { get; set; }
    public Guid IdVarinat { get; set; }
    public int Quantity { get; set; }

    //navigation

    public virtual ICollection<Images> Images { get; set; }
    public virtual Sizes Sizes { get; set; }
    public virtual Colors Colors { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }


}