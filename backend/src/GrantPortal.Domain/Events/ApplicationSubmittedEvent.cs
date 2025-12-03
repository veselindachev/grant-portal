namespace GrantPortal.Domain.Events;

public class ApplicationSubmittedEvent
{
    public Guid ApplicationId { get; init; }
    public Guid ApplicantId { get; init; }
}
