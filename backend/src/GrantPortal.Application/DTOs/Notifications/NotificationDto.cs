namespace GrantPortal.Application.DTOs.Notifications;

public record NotificationDto(Guid Id, Guid RecipientId, string Message, bool Read);
