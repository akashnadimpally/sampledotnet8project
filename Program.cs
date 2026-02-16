using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http;

[assembly: InternalsVisibleTo("tests")]

var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("PORT") ?? "3000";
var url = $"http://0.0.0.0:{port}";
var target = Environment.GetEnvironmentVariable("TARGET") ?? "World";

var app = builder.Build();

app.MapGet("/", () => Results.Text($"Hello {target}!", "text/html; charset=utf-8"));

app.Run(url);