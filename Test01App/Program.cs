var builder = WebApplication.CreateBuilder(args);

var testbuilder = builder.Build();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
