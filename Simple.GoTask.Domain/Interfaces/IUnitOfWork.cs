namespace Simple.GoTask.Domain.Interfaces;

public interface IUnitOfWork
{
    Task Commit(CancellationToken cancellationToken);
}
