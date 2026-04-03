
using DeviceManager.manager.repository;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DeviceManager.manager.service;
using DeviceManager.manager.entity;


namespace DeviceManager
{
    public class App
    {
        public static void Main(string[] args)
        {
            // we connect to the db to seed with values
            var options = new DbContextOptionsBuilder<DeviceManagerDbContext>()
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DeviceManagerDb;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            var dbContext = new DeviceManagerDbContext(options);

            DbSeeder.Seed(dbContext);
        }
    }
}
