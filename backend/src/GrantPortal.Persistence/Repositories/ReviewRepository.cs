using GrantPortal.Application.Abstractions.Repositories;
using GrantPortal.Domain.Entities.Reviews;
using GrantPortal.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GrantPortal.Persistence.Repositories;

public class ReviewRepository : IReviewRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ReviewRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Review?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext.Reviews.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task AddAsync(Review review, CancellationToken cancellationToken = default)
    {
        await _dbContext.Reviews.AddAsync(review, cancellationToken);
    }

    public Task UpdateAsync(Review review, CancellationToken cancellationToken = default)
    {
        _dbContext.Reviews.Update(review);
        return Task.CompletedTask;
    }
}
