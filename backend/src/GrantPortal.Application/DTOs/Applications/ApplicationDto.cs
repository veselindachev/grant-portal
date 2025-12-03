namespace GrantPortal.Application.DTOs.Applications;

public record ApplicationDto(Guid Id, Guid GrantProgramId, Guid ApplicantId, string Status);
