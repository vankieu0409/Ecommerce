namespace Ecommerce.Domain.Entities.Products;

public partial class VariantDetail
{
    public long IdVariant { get; set; }

    public long IdOption { get; set; }

    public long IdValue { get; set; }

    public virtual Option IdOptionNavigation { get; set; } = null!;

    public virtual Variants IdVariantNavigation { get; set; } = null!;

    public virtual OptionValues IdValueNavigation { get; set; } = null!;
}
