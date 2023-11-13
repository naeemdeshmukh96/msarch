using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/observations/{zip}", (string zip) =>
{
    return Results.Ok(zip);
});

app.Run();
