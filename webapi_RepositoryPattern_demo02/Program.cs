using Microsoft.EntityFrameworkCore;
using System.Configuration;
using webapi_RepositoryPattern_demo02;
using webapi_RepositoryPattern_demo02.Contracts;
using webapi_RepositoryPattern_demo02.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(opts =>
    opts.UseSqlServer("name=ConnectionStrings:sqlConnection"));

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

//opts.UseSqlServer(Configuration.GetConnection("sqlConnection"))
//);

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
