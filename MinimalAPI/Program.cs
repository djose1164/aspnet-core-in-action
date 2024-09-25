var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.UseWelcomePage("/"); This shorcircuit the pipeline by handling the request and returning a response
app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseRouting();

app.MapGet("/", () => "Hello World!");

app.Run();
