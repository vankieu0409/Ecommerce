using System.Reflection;

using Ecommerce.Shared.Domains;
using Ecommerce.Shared.Domains.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Ecommerce.Shared.Common.Repositories;

public class RepositoryBase<T, K> : RepositoryQueryBase<T, K> where T : EntityBase<K>
{
}

public class RepositoryBase<T, K, TContext> : RepositoryQueryBase<T, K, TContext>,
    IRepositoryBase<T, K, TContext>
    where T : EntityBase<K>
    where TContext : DbContext
{
    private readonly TContext _dbContext;
    private readonly IUnitOfWork<TContext> _unitOfWork;

    public RepositoryBase(TContext dbContext, IUnitOfWork<TContext> unitOfWork) : base(dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }

    public Task<IDbContextTransaction> BeginTransactionAsync() => _dbContext.Database.BeginTransactionAsync();

    public async Task EndTransactionAsync()
    {
        await SaveChangesAsync();
        await _dbContext.Database.CommitTransactionAsync();
    }

    public Task RollbackTransactionAsync() => _dbContext.Database.RollbackTransactionAsync();

    public void Create(T entity) => _dbContext.Set<T>().Add(entity);

    public async Task<K> CreateAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await SaveChangesAsync();
        return entity.Id;
    }

    public IList<K> CreateList(IEnumerable<T> entities)
    {
        _dbContext.Set<T>().AddRange(entities);
        return entities.Select(x => x.Id).ToList();
    }

    public async Task<IList<K>> CreateListAsync(IEnumerable<T> entities)
    {
        await _dbContext.Set<T>().AddRangeAsync(entities);
        await SaveChangesAsync();
        return entities.Select(x => x.Id).ToList();
    }

    public void Update(T entity)
    {
        if (_dbContext.Entry(entity).State == EntityState.Unchanged) return;

        T exist = _dbContext.Set<T>().Find(entity.Id);
        _dbContext.Entry(exist).CurrentValues.SetValues(entity);
    }

    public async Task UpdateAsync(T entity)
    {
        if (_dbContext.Entry(entity).State == EntityState.Unchanged) return;

        T exist = _dbContext.Set<T>().Find(entity.Id);
        _dbContext.Entry(exist).CurrentValues.SetValues(entity);
        await SaveChangesAsync();
    }

    public void UpdateList(IEnumerable<T> entities) => _dbContext.Set<T>().AddRange(entities);

    public async Task UpdateListAsync(IEnumerable<T> entities)
    {
        await _dbContext.Set<T>().AddRangeAsync(entities);
        await SaveChangesAsync();
    }

    public void Delete(T entity)
    {
        if (!this.IsInheritsFrom(typeof(T), typeof(IEntityAuditBase<>)))
            _dbContext.Set<T>().Remove(entity);


        PropertyInfo property = entity.GetType().GetProperty("IsDeleted");
        property.SetValue((object)entity, Convert.ChangeType((object)true, property.PropertyType), (object[])null);
        Update(entity);
    }

    public async Task DeleteAsync(T entity)
    {
        if (!this.IsInheritsFrom(typeof(T), typeof(IEntityAuditBase<>)))
        {
            _dbContext.Set<T>().Remove(entity);
            await SaveChangesAsync();
        }
        else
        {
            PropertyInfo property = entity.GetType().GetProperty("IsDeleted");
            property.SetValue((object)entity, Convert.ChangeType((object)true, property.PropertyType), (object[])null);
            await UpdateAsync(entity);
        }
    }

    public void DeleteList(IEnumerable<T> entities)
    {
        if (this.IsInheritsFrom(typeof(T), typeof(IEntityAuditBase<>)))
        {
            IEnumerable<T> removedEntities = entities.Select<T, T>((Func<T, T>)(entity =>
            {
                PropertyInfo property = entity.GetType().GetProperty("IsDeleted");
                property.SetValue((object)entity, Convert.ChangeType((object)true, property.PropertyType), (object[])null);
                return entity;
            }));
            UpdateList(removedEntities);
        }
        else
        {
            _dbContext.Set<T>().RemoveRange(entities);
        }
    }

    public async Task DeleteListAsync(IEnumerable<T> entities)
    {
        if (this.IsInheritsFrom(typeof(T), typeof(IEntityAuditBase<>)))
        {
            IEnumerable<T> removedEntities = entities.Select<T, T>((Func<T, T>)(entity =>
            {
                PropertyInfo property = entity.GetType().GetProperty("IsDeleted");
                property.SetValue((object)entity, Convert.ChangeType((object)true, property.PropertyType), (object[])null);
                return entity;
            }));
            await UpdateListAsync(removedEntities);
        }
        else
        {
            _dbContext.Set<T>().RemoveRange(entities);
            await SaveChangesAsync();
        }
    }

    public async Task<int> SaveChangesAsync() => await _unitOfWork.CommitAsync();

    private bool IsInheritsFrom(object source, Type baseType)
    {
        Type type1 = source.GetType();
        if (type1 == (Type)null)
            return false;
        if (baseType == (Type)null)
            return type1.IsInterface || type1 == typeof(object);
        if (baseType.IsInterface)
            return ((IEnumerable<Type>)type1.GetInterfaces()).Contains<Type>(baseType);
        Type type2 = type1;
        if (!(type2 != (Type)null))
            return false;
        if (type2.BaseType == baseType)
            return true;
        Type baseType1 = type2.BaseType;
        return this.IsInheritsFrom(source, baseType1);
    }

}