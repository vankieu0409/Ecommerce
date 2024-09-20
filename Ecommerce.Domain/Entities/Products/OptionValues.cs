using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public partial class OptionValues : EntityBase<long>
{

    public long IdOption { get; set; }

    public string? Value { get; set; }

    public virtual Option? IdOptionNavigation { get; set; }

    public virtual ICollection<VariantDetail> VariantDetails { get; set; } = new List<VariantDetail>();
}
