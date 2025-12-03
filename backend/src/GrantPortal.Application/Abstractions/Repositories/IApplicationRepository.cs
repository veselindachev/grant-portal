using GrantPortal.Domain.Entities.Applications;

namespace GrantPortal.Application.Abstractions.Repositories;

public interface IApplicationRepository
{
    Task<Application?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task AddAsync(Application application, CancellationToken cancellationToken = default);
    Task UpdateAsync(Application application, CancellationToken cancellationToken = default);
}
