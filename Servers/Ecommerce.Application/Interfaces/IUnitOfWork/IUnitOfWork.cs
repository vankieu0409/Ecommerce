namespace Ecommerce.Application.Interfaces.IUnitOfWork;

public interface IUnitOfWork : IDisposable
{
    public Task BeginTransaction();
    public Task CommitTransaction();
    public Task RollbackTransaction();
    public Task SaveChange();

}