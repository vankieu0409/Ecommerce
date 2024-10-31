using Ecommerce.Application.DTOs;

namespace Ecommerce.API.ViewModels;

public record CreateOrderViewModel(Guid CustomerId, string FullName, string Email, string Address, string Ward, string District, string City, string PhoneNumber, decimal Payments, decimal Refund, DateTime PaymentDate, DateTime CreationDate, string Status, string Voucher, decimal TotalAmount, ICollection<CreateOrderDetailViewModel> OrderDetails);

public static class CreateOrderViewModelExtensions
{
    public static CreateOrderDto ToDto(this CreateOrderViewModel viewModel)
    {
        return new CreateOrderDto
        {
            CustomerId = viewModel.CustomerId,
            FullName = viewModel.FullName,
            Email = viewModel.Email,
            Address = viewModel.Address,
            Ward = viewModel.Ward,
            District = viewModel.District,
            City = viewModel.City,
            PhoneNumber = viewModel.PhoneNumber,
            Payments = viewModel.Payments,
            Refund = viewModel.Refund,
            PaymentDate = viewModel.PaymentDate,
            CreationDate = viewModel.CreationDate,
            Status = viewModel.Status,
            Voucher = viewModel.Voucher,
            TotalAmount = viewModel.TotalAmount,
            OrderDetails = viewModel.OrderDetails.Select(x => x.ToDto()).ToList()
        };
    }
}