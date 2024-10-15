using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public class Images : EntityAuditBase<Guid>
{
    public Guid IdVariant { get; set; }
    public string URL { get; set; }
    public string Name { get; set; }
    public virtual Variants Variants { get; set; }

}