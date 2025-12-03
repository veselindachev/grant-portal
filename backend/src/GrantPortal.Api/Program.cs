using GrantPortal.Application;

var builder = WebApplication.CreateBuilder(args);

// TODO: Wire up services, middleware, and endpoints.

var app = builder.Build();

app.MapGet("/health", () => Results.Ok());

app.Run();
