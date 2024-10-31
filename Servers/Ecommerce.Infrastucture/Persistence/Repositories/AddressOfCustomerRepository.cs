using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Author;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;

using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class AddressOfCustomerRepository : RepositoryAsync<AddressOfCustomer>, IAddressOfCustomerRepository
{
    private readonly ApplicationDbContext _dbContext;

    public AddressOfCustomerRepository(ApplicationDbContext dbContext, ILogger<RepositoryAsync<AddressOfCustomer>> logger) : base(dbContext, logger)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        logger.LogInformation("\n AddressOfCustomerRepository initialized.\n");
    }
}