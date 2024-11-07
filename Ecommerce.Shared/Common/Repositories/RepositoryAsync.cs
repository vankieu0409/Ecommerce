using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;

using Ecommerce.Shared.Domains.Interfaces;
using Ecommerce.Shared.Domains.Interfaces.Audited;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Shared.Common.Repositories;

public class RepositoryAsync<TEntity> : IRepositoryAsync<TEntity>, IDisposable where TEntity : class, IEntity
{
    private readonly DbContext _dbContext;
    private readonly ILogger<RepositoryAsync<TEntity>> _logger;

    public DbSet<TEntity> Entities { get; set; }

    public RepositoryAsync(DbContext dbContext, ILogger<RepositoryAsync<TEntity>> logger)
    {
        this._dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        this.Entities = this._dbContext.Set<TEntity>();
        this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken))
    {
        _logger.LogInformation("Adding entity of type {EntityType}", typeof(TEntity).Name);
        this.PreSaveChange(entity);
        var result = (await this.Entities.AddAsync(entity, cancellationToken)).Entity;
        _logger.LogInformation("Entity added successfully");
        return result;
    }

    public async Task<IEnumerable<TEntity>> AddRangeAsync(
      IEnumerable<TEntity> entities,
      CancellationToken cancellationToken = default(CancellationToken))
    {
        _logger.LogInformation("Adding range of entities of type {EntityType}", typeof(TEntity).Name);
        Collection<TEntity> resullt = new Collection<TEntity>();
        foreach (var entity in entities)
        {
            resullt.Add(await this.AddAsync(entity, cancellationToken));
        }
        _logger.LogInformation("Range of entities added successfully");
        return resullt;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken))
    {
        _logger.LogInformation("Updating entity of type {EntityType}", typeof(TEntity).Name);
        this.PreSaveChange(entity);
        var result = await Task.FromResult<TEntity>(this.Entities.Update(entity).Entity);
        _logger.LogInformation("Entity updated successfully");
        return result;
    }

    public async Task<IEnumerable<TEntity>> UpdateRangeAsync(
      IEnumerable<TEntity> entities,
      CancellationToken cancellationToken = default(CancellationToken))
    {
        _logger.LogInformation("Updating range of entities of type {EntityType}", typeof(TEntity).Name);
        Collection<TEntity> result = new Collection<TEntity>();
        foreach (TEntity entity in entities)
        {
            result.Add(await this.UpdateAsync(entity, cancellationToken));
        }
        _logger.LogInformation("Range of entities updated successfully");
        return result;
    }

    public async Task<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken))
    {
        _logger.LogInformation("Removing entity of type {EntityType}", typeof(TEntity).Name);
        if (!this.IsInheritsFrom(typeof(TEntity), typeof(IDeletionAuditedEntity)))
        {
            var result = await Task.FromResult<TEntity>(this.Entities.Remove(entity).Entity);
            _logger.LogInformation("Entity removed successfully");
            return result;
        }
        PropertyInfo property = entity.GetType().GetProperty("IsDeleted");
        property.SetValue(entity, Convert.ChangeType(true, property.PropertyType), (object[])null);
        var updatedEntity = await this.UpdateAsync(entity, cancellationToken);
        _logger.LogInformation("Entity marked as deleted");
        return updatedEntity;
    }

    public async Task<TEntity> RemoveAsyn(TEntity entity, CancellationToken cancellationToken = default(CancellationToken))
    {
        _logger.LogInformation("Removing entity of type {EntityType}", typeof(TEntity).Name);
        this.Entities.Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken); // Đảm bảo gọi SaveChangesAsync
        _logger.LogInformation("Entity removed successfully");
        return entity;
    }

    public async Task<IEnumerable<TEntity>> RemoveRangeAsync(
      IEnumerable<TEntity> entities,
      CancellationToken cancellationToken = default(CancellationToken))
    {
        _logger.LogInformation("Removing range of entities of type {EntityType}", typeof(TEntity).Name);
        if (this.IsInheritsFrom(typeof(TEntity), typeof(IDeletionAuditedEntity)))
        {
            IEnumerable<TEntity> removedEntities = entities.Select<TEntity, TEntity>(entity =>
            {
                PropertyInfo property = entity.GetType().GetProperty("IsDeleted");
                property.SetValue(entity, Convert.ChangeType(true, property.PropertyType), (object[])null);
                return entity;
            });
            await this.UpdateRangeAsync(removedEntities);
            _logger.LogInformation("Range of entities marked as deleted");
            return await Task.FromResult<IEnumerable<TEntity>>(removedEntities);
        }
        this.Entities.RemoveRange(entities);
        _logger.LogInformation("Range of entities removed successfully");
        return await Task.FromResult<IEnumerable<TEntity>>(entities);
    }

    public virtual IQueryable<TEntity> AsQueryable() => this._dbContext.Set<TEntity>();
    public virtual IEnumerable<TEntity> AsEnumerable(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var items = _dbContext.Set<TEntity>().AsQueryable();
        var a = _dbContext.Set<TEntity>();
        items = includeProperties.Aggregate(items, (current, includeProperty) => current.Include(includeProperty));
        return items;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        _logger.LogInformation("Saving changes to the database");
        var result = await this._dbContext.SaveChangesAsync(cancellationToken);
        _logger.LogInformation("Changes saved successfully");
        return result;
    }

    public void Dispose()
    {
        this._dbContext?.Dispose();
        GC.SuppressFinalize(this);
        _logger.LogInformation("DbContext Disposed! ");
    }

    private void PreSaveChange(TEntity entity)
    {
        foreach (PropertyInfo property in entity.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
        {
            switch (property.GetValue(entity, (object[])null))
            {
                case DateTime dateTime2:
                    DateTime dateTime1 = this.Truncate(dateTime2, TimeSpan.FromSeconds(1.0));
                    property.SetValue(entity, Convert.ChangeType(dateTime1, property.PropertyType), (object[])null);
                    break;
                case DateTimeOffset dateTime3:
                    DateTimeOffset dateTimeOffset = this.Truncate(dateTime3, TimeSpan.FromSeconds(1.0));
                    property.SetValue(entity, Convert.ChangeType(dateTimeOffset, property.PropertyType), (object[])null);
                    break;
            }
        }
    }

    private DateTime Truncate(DateTime dateTime, TimeSpan timeSpan) => timeSpan == TimeSpan.Zero || dateTime == DateTime.MinValue || dateTime == DateTime.MaxValue ? dateTime : dateTime.AddTicks(-(dateTime.Ticks % timeSpan.Ticks));

    private DateTimeOffset Truncate(DateTimeOffset dateTime, TimeSpan timeSpan) => timeSpan == TimeSpan.Zero || dateTime == DateTimeOffset.MinValue || dateTime == DateTimeOffset.MaxValue ? dateTime : dateTime.AddTicks(-(dateTime.Ticks % timeSpan.Ticks));

    private bool IsInheritsFrom(object source, Type baseType)
    {
        Type type1 = source.GetType();
        if (type1 == null)
            return false;
        if (baseType == null)
            return type1.IsInterface || type1 == typeof(object);
        if (baseType.IsInterface)
            return type1.GetInterfaces().Contains<Type>(baseType);
        Type type2 = type1;
        if (!(type2 != null))
            return false;
        if (type2.BaseType == baseType)
            return true;
        Type baseType1 = type2.BaseType;
        return this.IsInheritsFrom(source, baseType1);
    }

    private bool IsInheritsFrom(Type sourceType, Type baseType)
    {
        if (sourceType == null)
            return false;
        if (baseType == null)
            return sourceType.IsInterface || sourceType == typeof(object);
        if (baseType.IsInterface)
            return sourceType.GetInterfaces().Contains<Type>(baseType);
        Type type = sourceType;
        if (!(type != null))
            return false;
        if (type.BaseType == baseType)
            return true;
        Type baseType1 = type.BaseType;
        return this.IsInheritsFrom(sourceType, baseType1);
    }
}
