namespace GrantPortal.Contracts.Responses;

public record NotificationResponse(Guid Id, string Message, bool Read);
