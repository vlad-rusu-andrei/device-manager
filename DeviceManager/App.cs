
using DeviceManager.manager.repository;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DeviceManager.manager.service;


namespace DeviceManager
{
    public class App
    {
        public static void Main(string[] args)
        {
            var options = new DbContextOptionsBuilder<DeviceManagerDbContext>()
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DeviceManagerDb;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            var dbContext = new DeviceManagerDbContext(options);

            var userService = new UserService(dbContext);
            var deviceService = new DeviceService(dbContext);

            DbSeeder.Seed(dbContext);

            //var users = userService.GetAllUsers();
            //Console.WriteLine(users.Count);
        }
    }
}
