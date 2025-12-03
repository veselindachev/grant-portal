using GrantPortal.Application.Abstractions.Messaging;
using GrantPortal.Application.DTOs.Auth;

namespace GrantPortal.Application.Features.Auth;

public record LoginCommand(string Email, string Password) : ICommand<AuthDto>;
