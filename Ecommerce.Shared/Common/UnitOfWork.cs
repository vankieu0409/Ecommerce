using Ecommerce.Shared.Domains.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Shared.Common;

public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
{
    private readonly TContext _context;

    public UnitOfWork(TContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        _context?.Dispose();
        GC.SuppressFinalize((object)this);
    }

    public Task<int> CommitAsync() => _context.SaveChangesAsync();
}