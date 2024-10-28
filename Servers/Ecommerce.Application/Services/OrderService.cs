using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Application.Interfaces.IServices;
using Ecommerce.Application.Interfaces.IUnitOfWork;
using Ecommerce.Domain.Entities.Author;
using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Enum;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _order;
    private readonly IAddressOfCustomerRepository _addressOfCustomer;
    private readonly ICustomerRepository _customer;
    private readonly IProductRepository _product;
    private readonly IOrderDetailRepository _orderDetail;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRoleRepository _role;
    private readonly ILogger _logger;

    public OrderService(IRoleRepository role, IOrderRepository order, IAddressOfCustomerRepository addressOfCustomer, ICustomerRepository customer, IProductRepository product, IOrderDetailRepository orderDetail, IUnitOfWork unitOfWork, ILogger logger)
    {
        _order = order ?? throw new ArgumentNullException(nameof(order));
        _addressOfCustomer = addressOfCustomer ?? throw new ArgumentNullException(nameof(addressOfCustomer));
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _product = product ?? throw new ArgumentNullException(nameof(product));
        _orderDetail = orderDetail ?? throw new ArgumentNullException(nameof(orderDetail));
        _role = role ?? throw new ArgumentNullException(nameof(role));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }
    public async Task CreateOrder(CreateOrderDto request)
    {
        await _unitOfWork.BeginTransaction();
        try
        {
            var customer = await _customer.AsQueryable()
                .FirstOrDefaultAsync(c => c.Email == request.Email || c.PhoneNumber == request.PhoneNumber);
            if (customer == null)
            {
                var role = await _role.AsQueryable().FirstOrDefaultAsync(r => r.Name == Role.Customer.ToString());
                customer = new Customer
                {
                    Id = Guid.NewGuid(),
                    IdRole = role!.Id,
                    FullName = request.FullName,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber
                };
                await _customer.AddAsync(customer);
                await _unitOfWork.SaveChange();
                var addressCustomer = new AddressOfCustomer()
                {
                    Id = Guid.NewGuid(),
                    CustomerId = customer.Id,
                    Address = request.Address,
                    Ward = request.Ward,
                    District = request.District,
                    City = request.City
                };
                await _addressOfCustomer.AddAsync(addressCustomer);
                await _unitOfWork.SaveChange();

                var order = new Order()
                {
                    Id = Guid.NewGuid(),
                    CustomerId = customer.Id,
                    PaymentDate = DateTime.Now,
                    Payments = request.Payments,
                    Refund = request.Payments - request.TotalAmount,

                };
            }

        }
        catch (Exception e)
        {

        }

    }
}
}