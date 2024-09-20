using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Shared.Domains.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> CommitAsync();
}

public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
{
}