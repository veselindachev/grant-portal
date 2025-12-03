namespace GrantPortal.Domain.Repositories;

public interface IAggregateRepository<TRoot>
{
    Task<TRoot?> GetAsync(Guid id, CancellationToken cancellationToken = default);
    Task SaveAsync(TRoot aggregate, CancellationToken cancellationToken = default);
}
