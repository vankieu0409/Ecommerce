using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products;
public class Variants : EntityBase<long>
{
    public long IdProduct { get; set; }
    public string Color { get; set; } // Màu sắc của giày
    public string Size { get; set; } // Kích cỡ của giày
    public decimal Price { get; set; } // Giá của giày
    public int Quantity { get; set; } // Số lượng của giày
}