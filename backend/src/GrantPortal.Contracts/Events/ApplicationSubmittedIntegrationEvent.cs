namespace GrantPortal.Contracts.Events;

public record ApplicationSubmittedIntegrationEvent(Guid ApplicationId, Guid ApplicantId, DateTime SubmittedAt);
