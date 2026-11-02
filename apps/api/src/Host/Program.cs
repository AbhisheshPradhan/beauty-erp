var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/v1/health", () => Results.Ok(new { status = "ok" }));

app.Run();