namespace GrantPortal.Domain.Entities.Notifications;

public class Notification
{
    public Guid Id { get; set; }
    public Guid RecipientId { get; set; }
    public string Message { get; set; } = string.Empty;
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
}
