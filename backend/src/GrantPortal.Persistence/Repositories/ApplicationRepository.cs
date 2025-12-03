using GrantPortal.Application.Abstractions.Repositories;
using GrantPortal.Domain.Entities.Applications;
using GrantPortal.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GrantPortal.Persistence.Repositories;

public class ApplicationRepository : IApplicationRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ApplicationRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Application?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Applications
            .Include(x => x.Answers)
            .Include(x => x.Attachments)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task AddAsync(Application application, CancellationToken cancellationToken = default)
    {
        await _dbContext.Applications.AddAsync(application, cancellationToken);
    }

    public Task UpdateAsync(Application application, CancellationToken cancellationToken = default)
    {
        _dbContext.Applications.Update(application);
        return Task.CompletedTask;
    }
}
