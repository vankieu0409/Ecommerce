using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;

using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class OrderRepository : RepositoryAsync<Order>, IOrderRepository
{
    private readonly ApplicationDbContext _dbContext;

    public OrderRepository(ApplicationDbContext dbContext, ILogger<RepositoryAsync<Order>> logger) : base(dbContext, logger)
    {
        _dbContext = dbContext ?? throw new AggregateException(nameof(dbContext));
        logger.LogInformation("\nOrderRepository initialized.\n");
    }
}