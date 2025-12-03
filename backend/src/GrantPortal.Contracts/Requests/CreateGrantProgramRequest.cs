namespace GrantPortal.Contracts.Requests;

public record CreateGrantProgramRequest(string Name, string Description, string FormDefinitionJson);
