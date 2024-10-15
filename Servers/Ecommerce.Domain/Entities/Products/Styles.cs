using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public class Styles : EntityAuditBase<Guid>
{
    public string Style { get; set; } // Loại Chất Liệu
    public string Detail { get; set; } // Chi tiết
    public virtual Collection<Products> Products { get; set; }
}