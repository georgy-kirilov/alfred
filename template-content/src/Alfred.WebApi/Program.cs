var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/greet", (string name) => $"Hello, {name}!");

app.Run();

public sealed partial class Program();
