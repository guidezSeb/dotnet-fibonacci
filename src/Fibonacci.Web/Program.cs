using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/Fibonacci", 
    async () => await Fibonacci.Fibo.ExecuteAsync(new []{"44", "43"}));

app.Run();