using System.Linq.Expressions;

using Ecommerce.Shared.Domains.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Shared.Common.Repositories;

public interface IRepositoryAsync<TEntity> : IDisposable where TEntity : class, IEntity
{

    DbSet<TEntity> Entities { get; set; }

    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

    Task<IEnumerable<TEntity>> AddRangeAsync(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

    Task<IEnumerable<TEntity>> UpdateRangeAsync(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default(CancellationToken));

    Task<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

    Task<IEnumerable<TEntity>> RemoveRangeAsync(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default(CancellationToken));

    IQueryable<TEntity> AsQueryable();
    IEnumerable<TEntity> AsEnumerable(params Expression<Func<TEntity, object>>[] includeProperties);

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
}