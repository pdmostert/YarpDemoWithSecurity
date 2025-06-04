using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/hello", () =>
    {
        return Results.Ok("Hello World!");
    });

//app.UseHttpsRedirection();

app.Run();

