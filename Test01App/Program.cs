using Microsoft.AspNetCore.Server.IIS;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run(async (HttpContext context) => {
    if (context != null)
    {
        context.Response.StatusCode = 200;
        context.Response.Headers["MyKey"] = "My Value";
        context.Response.Headers["Server"] = "My Server";
        context.Response.Headers["Content-type"] = "txt/html";
    }
    else
    {
        context.Response.StatusCode = 500;
        context.Response.Headers["MyKey"] = "My Value";
        context.Response.Headers["Server"] = "My Server";
        context.Response.Headers["Content-type"] = "txt/html";
    }
    await context.Response.WriteAsync("<h1>Hello</h1>");
    await context.Response.WriteAsync("World");

});

app.Run();
