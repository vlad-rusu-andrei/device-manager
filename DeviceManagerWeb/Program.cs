using DeviceManager.manager.repository;
using DeviceManager.manager.service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// db context
builder.Services.AddDbContext<DeviceManagerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


// cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy
            .WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader());
});


// services
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<DeviceService>();

builder.Services.AddControllers();

var app = builder.Build();
app.UseCors("AllowAngular");
app.MapControllers();
app.Run();
