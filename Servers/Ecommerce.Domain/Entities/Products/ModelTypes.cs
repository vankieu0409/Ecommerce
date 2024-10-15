using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public class ModelTypes : EntityAuditBase<Guid>
{
    public string ModelType { get; set; } // Loại Chất Liệu
    public string Detail { get; set; } // Chi tiết

    public virtual Collection<Products> Products { get; set; }
}
