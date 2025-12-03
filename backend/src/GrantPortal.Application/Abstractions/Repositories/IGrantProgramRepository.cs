using GrantPortal.Domain.Entities.Grants;

namespace GrantPortal.Application.Abstractions.Repositories;

public interface IGrantProgramRepository
{
    Task<GrantProgram?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task AddAsync(GrantProgram grantProgram, CancellationToken cancellationToken = default);
    Task UpdateAsync(GrantProgram grantProgram, CancellationToken cancellationToken = default);
}
