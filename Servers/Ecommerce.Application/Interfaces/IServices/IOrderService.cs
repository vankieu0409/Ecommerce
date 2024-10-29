using Ecommerce.Application.DTOs;

namespace Ecommerce.Application.Interfaces.IServices;

public interface IOrderService
{
    public Task CreateOrder(CreateOrderDto request);
}