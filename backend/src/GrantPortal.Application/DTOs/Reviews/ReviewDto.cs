namespace GrantPortal.Application.DTOs.Reviews;

public record ReviewDto(Guid Id, Guid ApplicationId, Guid ReviewerId, int Score, string Comments);
