using System.Globalization;
using SistemaBanco;
using SistemaBanco.Controllers;
using SistemaBanco.Interfaces;

var builder = WebApplication.CreateBuilder();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClientesServices, ClientesServices>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();