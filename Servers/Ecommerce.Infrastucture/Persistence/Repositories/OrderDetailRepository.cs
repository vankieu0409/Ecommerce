using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;

using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class OrderDetailRepository : RepositoryAsync<OrderDetail>, IOrderDetailRepository
{
    private readonly ApplicationDbContext _dbContext;
    public OrderDetailRepository(ApplicationDbContext dbContext, ILogger<RepositoryAsync<OrderDetail>> logger) : base(dbContext, logger)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        logger.LogInformation("\n OrderDetailRepository initialized.\n");
    }
}