using GrantPortal.Application.Abstractions.Repositories;
using GrantPortal.Domain.Entities.Notifications;
using GrantPortal.Persistence.Contexts;

namespace GrantPortal.Persistence.Repositories;

public class NotificationRepository : INotificationRepository
{
    private readonly ApplicationDbContext _dbContext;

    public NotificationRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(Notification notification, CancellationToken cancellationToken = default)
    {
        await _dbContext.Notifications.AddAsync(notification, cancellationToken);
    }

    public Task UpdateAsync(Notification notification, CancellationToken cancellationToken = default)
    {
        _dbContext.Notifications.Update(notification);
        return Task.CompletedTask;
    }
}
