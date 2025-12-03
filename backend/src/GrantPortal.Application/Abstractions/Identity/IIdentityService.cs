namespace GrantPortal.Application.Abstractions.Identity;

public interface IIdentityService
{
    Task<Guid> RegisterAsync(string email, string password, string role, CancellationToken cancellationToken = default);
    Task<string> GenerateTokenAsync(Guid userId, CancellationToken cancellationToken = default);
}
