using GrantPortal.Application.Abstractions.Messaging;
using GrantPortal.Application.DTOs.Applications;

namespace GrantPortal.Application.Features.Applications;

public record CreateApplicationCommand(Guid GrantProgramId, Guid ApplicantId) : ICommand<ApplicationDto>;
