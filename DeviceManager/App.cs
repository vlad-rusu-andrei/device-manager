
using DeviceManager.manager.repository;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DeviceManager
{
    public class App
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddDbContext<DeviceManagerDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            var host = builder.Build();

            // seeding
            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<DeviceManagerDbContext>();
                DbSeeder.Seed(context);
            }

            host.Run();
        }
    }
}
