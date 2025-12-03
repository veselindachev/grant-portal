namespace GrantPortal.Application.DTOs.Auth;

public record AuthDto(Guid UserId, string Email, string Token);
