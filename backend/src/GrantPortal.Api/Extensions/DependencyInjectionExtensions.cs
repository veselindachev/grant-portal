using GrantPortal.Application;
using GrantPortal.Infrastructure;
using GrantPortal.Persistence;

namespace GrantPortal.Api.Extensions;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddApiLayer(this IServiceCollection services)
    {
        // TODO: Register API-specific services, filters, and middleware.
        return services;
    }

    public static WebApplication UseApiLayer(this WebApplication app)
    {
        // TODO: Configure middleware pipeline.
        return app;
    }
}
