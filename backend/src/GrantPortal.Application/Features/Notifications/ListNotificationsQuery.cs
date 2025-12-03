using GrantPortal.Application.Abstractions.Messaging;
using GrantPortal.Application.DTOs.Notifications;

namespace GrantPortal.Application.Features.Notifications;

public record ListNotificationsQuery(Guid RecipientId) : IQuery<IEnumerable<NotificationDto>>;
