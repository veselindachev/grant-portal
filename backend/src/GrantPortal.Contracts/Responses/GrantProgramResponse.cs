namespace GrantPortal.Contracts.Responses;

public record GrantProgramResponse(Guid Id, string Name, string Description, string FormDefinitionJson);
