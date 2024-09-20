using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;
public partial class Variants : EntityBase<long>
{
    public long IdProduct { get; set; }

    public string? VariantName { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }
    public List<string>? Images { get; set; }

    public virtual Products? IdProductNavigation { get; set; }

    public virtual ICollection<VariantDetail> VariantDetails { get; set; } = new List<VariantDetail>();
}