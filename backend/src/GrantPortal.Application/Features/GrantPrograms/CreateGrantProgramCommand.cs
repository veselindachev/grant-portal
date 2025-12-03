using GrantPortal.Application.Abstractions.Messaging;
using GrantPortal.Application.DTOs.Grants;

namespace GrantPortal.Application.Features.GrantPrograms;

public record CreateGrantProgramCommand(string Name, string Description, string FormDefinitionJson) : ICommand<GrantProgramDto>;
