using Microsoft.AspNetCore.Server.IIS;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run(async (HttpContext context) =>
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsync("Hello");
        await context.Response.WriteAsync("World");

});

app.Run();
