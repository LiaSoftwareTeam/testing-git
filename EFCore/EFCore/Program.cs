using Microsoft.EntityFrameworkCore;   // Para DbContext y EF Core
using AutoMapper;                      // Para IMapper, Profile y AddAutoMapper
using EFCore.Utilidades;               // Para tu AutoMapperProfile
using EFCore.Entidades;                // Para tus entidades, si las vas a usar aquí
using EFCore.DTOs;
using EFCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//inyectar para usar la clase e indeicar la bd que se usará
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=SqlServer"));

//agregar AutoMapper al controlador de dependencias
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<AutoMapperProfile>();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
