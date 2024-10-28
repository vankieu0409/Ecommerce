namespace Ecommerce.Application.Interfaces.IUnitOfWork;

public interface IUnitOfWork : IDisposable
{
    Task BeginTransaction();
    Task CommitTransaction();
    Task RollbackTransaction();
    Task SaveChange();

}