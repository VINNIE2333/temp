using Microsoft.EntityFrameworkCore;
using TundraApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TundraDBContext>(
    options => options.UseSqlServer("name=ConnectionStrings:Default")
    );

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
