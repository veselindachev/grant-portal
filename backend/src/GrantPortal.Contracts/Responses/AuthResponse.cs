namespace GrantPortal.Contracts.Responses;

public record AuthResponse(string Token, string Email, string Role);
