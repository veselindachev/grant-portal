namespace GrantPortal.Contracts.Requests;

public record RegisterRequest(string Email, string Password, string FullName);
