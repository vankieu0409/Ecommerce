using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public class Sizes : EntityAuditBase<Guid>
{
    public string Size { get; set; }


    public virtual Collection<Variants> Variants { get; set; }

}