namespace Ecommerce.Application.DTOs;

public class CreateOrderDto : BaseDto
{
    //Customer
    public Guid CustomerId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Ward { get; set; }  // Phường/Xã
    public string District { get; set; }  // Quận/Huyện
    public string City { get; set; }  // Thành phố/Tỉnh
    public string PhoneNumber { get; set; }

    //Order
    public decimal Payments { get; set; }
    public decimal Refund { get; set; }
    public DateTime PaymentDate { get; set; }
    public DateTime CreationDate { get; set; }
    public string Status { get; set; }
    public string Voucher { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<OrderDetailDto> OrderDetails { get; set; }

    //Employee

    public Guid EmployeeId { get; set; }
}