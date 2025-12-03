using GrantPortal.Application.Abstractions.Repositories;
using GrantPortal.Domain.Entities.Grants;
using GrantPortal.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GrantPortal.Persistence.Repositories;

public class GrantProgramRepository : IGrantProgramRepository
{
    private readonly ApplicationDbContext _dbContext;

    public GrantProgramRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<GrantProgram?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext.GrantPrograms.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task AddAsync(GrantProgram grantProgram, CancellationToken cancellationToken = default)
    {
        await _dbContext.GrantPrograms.AddAsync(grantProgram, cancellationToken);
    }

    public Task UpdateAsync(GrantProgram grantProgram, CancellationToken cancellationToken = default)
    {
        _dbContext.GrantPrograms.Update(grantProgram);
        return Task.CompletedTask;
    }
}
