using DeviceManager.manager.repository;
using DeviceManager.manager.service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// db context
builder.Services.AddDbContext<DeviceManagerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


// services
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<DeviceService>();

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
