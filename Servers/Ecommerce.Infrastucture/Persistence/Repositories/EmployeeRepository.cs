using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Author;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;

using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class EmployeeRepository : RepositoryAsync<Employee>, IEmployeeRepository
{
    private readonly ApplicationDbContext _dbContext;

    public EmployeeRepository(ApplicationDbContext dbContext, ILogger<RepositoryAsync<Employee>> logger) : base(dbContext, logger)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        logger.LogInformation("\n EmployeeRepository initialized.\n");
    }
}