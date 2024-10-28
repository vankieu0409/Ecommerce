using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;

using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class ProductRepository : RepositoryAsync<Products>, IProductRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ProductRepository(ApplicationDbContext dbContext, ILogger<RepositoryAsync<Products>> logger) : base(dbContext, logger)
    {
        _dbContext = dbContext ?? throw new AggregateException(nameof(dbContext));
        logger.LogInformation("\nProductRepository initialized.\n");
    }
}
