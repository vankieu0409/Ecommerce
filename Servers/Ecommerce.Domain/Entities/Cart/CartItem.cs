using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Cart;

public class CartItem : EntityBase<Guid>
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int VariantId { get; set; }
    public int Quantity { get; set; } = 1;
}