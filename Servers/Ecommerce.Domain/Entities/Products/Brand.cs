using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public class Brand : EntityAuditBase<Guid>
{
    public string BrandName { get; set; } // Tên thương hiệu
    public string Detail { get; set; } // Chi tiết
    public virtual Collection<Products> Products { get; set; }
}