var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapReverseProxy();

//app.UseHttpsRedirection();

app.Run();
