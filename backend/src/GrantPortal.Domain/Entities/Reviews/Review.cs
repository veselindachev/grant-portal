using GrantPortal.Domain.Enums;

namespace GrantPortal.Domain.Entities.Reviews;

public class Review
{
    public Guid Id { get; set; }
    public Guid ApplicationId { get; set; }
    public Guid ReviewerId { get; set; }
    public int Score { get; set; }
    public string Comments { get; set; } = string.Empty;
    public ReviewStatus Status { get; set; }
}
