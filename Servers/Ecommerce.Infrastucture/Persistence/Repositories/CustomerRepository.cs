using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Author;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;

using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class CustomerRepository : RepositoryAsync<Customer>, ICustomerRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CustomerRepository(ApplicationDbContext dbContext, ILogger<RepositoryAsync<Customer>> logger) : base(dbContext, logger)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        logger.LogInformation("\n CustomerRepository initialized.\n");
    }
}