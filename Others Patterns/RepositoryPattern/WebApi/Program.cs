using Scalar.AspNetCore;
using WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApiConfiguration(builder.Configuration);
builder.Services.RegisterServices();

var app = builder.Build();
app.UseApiConfiguration(builder.Environment);

app.MapOpenApi();
app.MapScalarApiReference(options => options
    .WithTheme(ScalarTheme.Default)
    .WithTitle("Scalar Docs")
);

app.Run();
