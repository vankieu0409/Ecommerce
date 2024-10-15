using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public class Category : EntityAuditBase<Guid>
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public virtual Collection<Products> Products { get; set; }
}