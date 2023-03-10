using Microsoft.EntityFrameworkCore;
using RuiMoraes.Teste.EstoqueAPI.Data.Context;
using RuiMoraes.Teste.EstoqueAPI.Data.Interfaces;
using RuiMoraes.Teste.EstoqueAPI.Data.Repositories;
using RuiMoraes.Teste.EstoqueAPI.Mapping;
using RuiMoraes.Teste.EstoqueAPI.Services.Interfaces;
using RuiMoraes.Teste.EstoqueAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

builder.Services.AddAutoMapper(typeof(MappingConfig));

var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EstoqueAPIDbContext>(options => {
    options.UseSqlServer(conn);
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
