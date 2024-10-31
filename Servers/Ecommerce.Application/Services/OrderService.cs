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
    private readonly IVariantRepository _variant;
    private readonly IOrderDetailRepository _orderDetail;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRoleRepository _role;
    private ILogger<OrderService> _logger;

    private Employee e = new Employee
    {
        Id = Guid.NewGuid(),
        SocialSecurityNumber = "123-45-6789",
        FullName = "Nguyễn Văn B",
        DateOfBirth = new DateTime(1990, 5, 15),
        Gender = Gender.Male, // Replace with actual Gender enum value
        PlaceOfOrigin = "Hà Nội",
        ResidenceAddress = "456 Đường XYZ, Hà Nội",
        DistinctiveFeatures = "Chăm chỉ, nhiệt tình",
        IssueDate = new DateTime(2010, 1, 1),
        Avatar = "link_to_avatar_image",
        Nationality = "Việt Nam",
        PasswordHash = "hashed_password", // Replace with actual hashed password
        PhoneNumber = "0987654321",
        Email = "nguyenvanb@example.com",
        IdRole = Guid.NewGuid() // Replace with actual Role ID
    };


    public OrderService(IRoleRepository role, IOrderRepository order, IAddressOfCustomerRepository addressOfCustomer, ICustomerRepository customer, IVariantRepository variant, IOrderDetailRepository orderDetail, IUnitOfWork unitOfWork, ILogger<OrderService> logger)
    {
        _order = order ?? throw new ArgumentNullException(nameof(order));
        _addressOfCustomer = addressOfCustomer ?? throw new ArgumentNullException(nameof(addressOfCustomer));
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _variant = variant ?? throw new ArgumentNullException(nameof(variant));
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
                var roleString = Role.Customer.ToString();
                var role = await _role.AsQueryable().FirstOrDefaultAsync(r => r.Name == Role.Customer.ToString());
                customer = new Customer
                {
                    Id = Guid.NewGuid(),
                    //IdRole = role!.Id,
                    FullName = request.FullName,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    Image = "",
                    PasswordHash = "",
                    Role = role

                };
                await _customer.AddAsync(customer);
                await _unitOfWork.SaveChange();
                _logger.LogInformation($@"Created Customer {customer.Email}");
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
                _logger.LogInformation($@"Created addressCustomer {addressCustomer.Address} {addressCustomer.Ward}");
                await _unitOfWork.SaveChange();
                var e = new Employee
                {
                    Id = Guid.NewGuid(),
                    SocialSecurityNumber = "123-45-6789",
                    FullName = "Nguyễn Văn B",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Gender = Gender.Male, // Replace with actual Gender enum value
                    PlaceOfOrigin = "Hà Nội",
                    ResidenceAddress = "456 Đường XYZ, Hà Nội",
                    DistinctiveFeatures = "Chăm chỉ, nhiệt tình",
                    IssueDate = new DateTime(2010, 1, 1),
                    Avatar = "link_to_avatar_image",
                    Nationality = "Việt Nam",
                    PasswordHash = "hashed_password", // Replace with actual hashed password
                    PhoneNumber = "0987654321",
                    Email = "nguyenvanb@example.com",
                    Role = role// Replace with actual Role ID
                };
                var order = new Order()
                {
                    Id = Guid.NewGuid(),
                    CustomerId = customer.Id,
                    PaymentDate = DateTime.Now,
                    Payments = request.Payments,
                    Refund = request.Payments - request.TotalAmount,
                    Status = "",
                    Voucher = "",
                    //EmployeeId = Guid.Empty,
                    Employee = e
                };
                await _order.AddAsync(order);
                _logger.LogInformation($@"Created Order {order.Id}");
                await _unitOfWork.SaveChange();
                request.OrderDetails.ToList().ForEach(async x =>
                {
                    var product = await _variant.AsQueryable().FirstOrDefaultAsync(p => p.Id == x.VariantId);
                    var orderDetail = new OrderDetail()
                    {
                        Id = Guid.NewGuid(),
                        OrderId = order.Id,
                        VariantId = x.VariantId,
                        Quantity = x.Quantity,
                        TotalPrice = x.TotalPrice,
                    };
                    await _orderDetail.AddAsync(orderDetail);
                    _logger.LogInformation($@"Created OrderDetail {orderDetail.Id}");
                    await _unitOfWork.SaveChange();
                });
                await _unitOfWork.CommitTransaction();
                _logger.LogInformation($@"Commited ");
            }
        }
        catch (Exception e)
        {
            await _unitOfWork.RollbackTransaction();
            _logger.LogError(e.Message);
        }
        _logger.LogInformation($@"End Create Order ");
    }
}
