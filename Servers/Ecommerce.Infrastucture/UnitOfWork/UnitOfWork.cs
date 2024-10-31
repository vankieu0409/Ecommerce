using Ecommerce.Application.Interfaces.IUnitOfWork;
using Ecommerce.Infrastructure.Persistence.DBContext;

using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    private IDbContextTransaction _transaction;
    private readonly ILogger<UnitOfWork> _logger;

    public UnitOfWork(ApplicationDbContext context, ILogger<UnitOfWork> logger)
    {
        _context = context ?? throw new AggregateException(nameof(context));
        _logger = logger ?? throw new AggregateException(nameof(logger));
        logger.LogInformation("\n UnitOfWork initialized \n");
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _transaction?.Dispose();
            _context.Dispose();
            _logger.LogInformation("\n Disposed");
        }
    }

    public async Task BeginTransaction()
    {
        _transaction = await _context.Database.BeginTransactionAsync();
        _logger.LogInformation("\n BeginTransaction !");
    }

    public async Task CommitTransaction()
    {
        await _transaction.CommitAsync();
        _logger.LogInformation("\n CommitedTransaction !");
    }

    public async Task RollbackTransaction()
    {
        await _transaction.RollbackAsync();
        await _transaction.DisposeAsync();
        _logger.LogInformation("\n Rollback Transaction !");
    }

    public async Task SaveChange()
    {
        await _context.SaveChangesAsync();
        _logger.LogInformation("\n SaveChanges!");
    }
}