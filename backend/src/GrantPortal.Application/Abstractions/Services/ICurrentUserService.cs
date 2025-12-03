namespace GrantPortal.Application.Abstractions.Services;

public interface ICurrentUserService
{
    Guid UserId { get; }
    string? Email { get; }
    bool IsInRole(string role);
}
