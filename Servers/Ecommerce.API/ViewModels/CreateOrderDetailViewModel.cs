using Ecommerce.Application.DTOs;

namespace Ecommerce.API.ViewModels;

public record CreateOrderDetailViewModel(Guid VariantId, int Quantity, decimal UnitPrice);

public static class CreateOrderDetailViewModelExtensions
{
    public static OrderDetailDto ToDto(this CreateOrderDetailViewModel viewModel)
    {
        return new OrderDetailDto
        {
            VariantId = viewModel.VariantId,
            Quantity = viewModel.Quantity,
            UnitPrice = viewModel.UnitPrice,
            TotalPrice = viewModel.UnitPrice * viewModel.Quantity
        };
    }
}