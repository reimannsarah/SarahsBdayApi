using SarahBdayApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SarahBdayApiContext>(
                    dbContextOptions => dbContextOptions
                        .UseMySql(
                        builder.Configuration["ConnectionStrings:AZURE_SQL_CONNECTION"], 
                        ServerVersion.AutoDetect(
                            builder.Configuration["ConnectionStrings:AZURE_SQL_CONNECTION"]
                        )
                        )
                    );

builder.Services.AddCors(options => 
{
    options.AddDefaultPolicy(builder => 
    {
        builder.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.UseCors();

app.Run();
