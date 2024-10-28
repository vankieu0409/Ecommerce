using Ecommerce.Application.DTOs;

namespace Ecommerce.Application.Interfaces.IServices;

public interface IOrderService
{
    Task CreateOrder(CreateOrderDto request);
}