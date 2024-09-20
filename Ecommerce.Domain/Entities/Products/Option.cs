using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;

public partial class Option : EntityBase<long>
{

    public string? Name { get; set; }

    public virtual ICollection<OptionValues> OptionsValues { get; set; } = new List<OptionValues>();

    public virtual ICollection<VariantDetail> VariantDetails { get; set; } = new List<VariantDetail>();
}
