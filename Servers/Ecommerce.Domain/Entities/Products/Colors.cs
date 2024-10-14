using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public class Colors : EntityAuditBase<Guid>
{
    public string Color { get; set; }
    public Guid IdVadiant { get; set; }
    public virtual Collection<Variants> Variants { get; set; }
}