using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;

using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class VariantRepository : RepositoryAsync<Variants>, IVariantRepository
{
    private readonly ApplicationDbContext _dbContext;
    public VariantRepository(ApplicationDbContext dbContext, ILogger<RepositoryAsync<Variants>> logger) : base(dbContext, logger)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        logger.LogInformation("\n VariantRepository initialized.\n");
    }
}