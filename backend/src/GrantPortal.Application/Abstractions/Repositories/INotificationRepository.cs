using GrantPortal.Domain.Entities.Notifications;

namespace GrantPortal.Application.Abstractions.Repositories;

public interface INotificationRepository
{
    Task AddAsync(Notification notification, CancellationToken cancellationToken = default);
    Task UpdateAsync(Notification notification, CancellationToken cancellationToken = default);
}
