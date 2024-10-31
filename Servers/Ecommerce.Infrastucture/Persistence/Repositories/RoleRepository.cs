using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Author;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;

using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class RoleRepository : RepositoryAsync<RoleEntity>, IRoleRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RoleRepository(ApplicationDbContext dbContext, ILogger<RepositoryAsync<RoleEntity>> logger) : base(dbContext, logger)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        logger.LogInformation("\n RoleRepository initialized. ");
    }
}