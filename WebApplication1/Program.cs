using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpLogging(opts => opts.LoggingFields = HttpLoggingFields.RequestProperties);

builder.Logging.AddFilter("Microsoft.AspNetCore.HttpLoggin", LogLevel.Information);

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseHttpLogging();

app.MapGet("/", () => "Hello World!");
app.MapGet("/person", () => new Person("Daniel", "Victoriano"));

app.Run();


public record Person(string Firstname, string LastName);