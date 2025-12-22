using Microsoft.EntityFrameworkCore;
using Spectra.Data;
using Spectra.Mappings;
using Spectra.Models;
using Spectra.Models.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Add Database Context
builder.Services.AddDbContext<SpectraDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add AutoMapper - Scans assembly for Profile classes
// This is registered once and used throughout the app
builder.Services.AddAutoMapper(config =>
{
    config.AddProfile<MappingProfile>();
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Spectra v1");
        c.RoutePrefix = "swagger";
    });
}

// Redirect root to swagger
app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger/index.html", permanent: false);
    return Task.CompletedTask;
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
