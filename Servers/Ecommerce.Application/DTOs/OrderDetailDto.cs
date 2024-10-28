namespace Ecommerce.Application.DTOs;

public class OrderDetailDto : BaseDto
{
    public Guid VariantId { get; set; }
    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal TotalPrice { get; set; }

}