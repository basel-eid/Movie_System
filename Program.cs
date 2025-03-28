using Microsoft.EntityFrameworkCore;
using Movie_System;
using Movie_System.Repository.CategoryRepository;
using Movie_System.Repository.CinemaRepository;
using Movie_System.Repository.MovieRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));
builder.Services.AddScoped<IMovieRepo, MovieRepo>();
builder.Services.AddScoped<ICinemaRepo, CinemaRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
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
