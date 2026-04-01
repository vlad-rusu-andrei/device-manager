using DeviceManager.manager.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace DeviceManager.manager.repository
{
    public static class DbSeeder // used to populate DB with dummy data
    {
        public static void Seed(DeviceManagerDbContext dbContext)
        {
            if(dbContext.Devices.Any()) return;
            if(dbContext.Users.Any()) return;

            var deviceFaker = new Faker<Device>("en")
                .RuleFor(d => d.Name, f => f.PickRandom("Iphone 14", "Iphone 15", "Samsung Galaxy S25", "Samsung Galaxy S26", "Ipad 10", "Ipad 11", "Samsung Galaxy Tab S9", "Samsung Galaxy Tab S10"))
                .RuleFor(d => d.Manufacturer, f => f.PickRandom("Apple", "Samsung"))
                .RuleFor(d => d.Type, f => f.PickRandom<entity.Type>())
                .RuleFor(d => d.Os, f => f.PickRandom("Android", "iOS"))
                .RuleFor(d => d.Osversion, f => f.PickRandom("Android 16", "Android 15", "iOS 26.4", "iOS 25"))
                .RuleFor(d => d.Processor, f => f.PickRandom("Exynos 2600", "Exynos 2500", "A15 Bionic", "A16"))
                .RuleFor(d => d.Ram, f => f.PickRandom(4, 8, 16))
                .RuleFor(d => d.Description, f => f.Lorem.Sentence());

            var devices = deviceFaker.Generate(100);

            var locationFaker = new Faker<Location>()
                .RuleFor(d => d.City, f => f.Address.City())
                .RuleFor(d => d.Street, f => f.Address.StreetAddress())
                .RuleFor(d => d.Number, f => f.Address.BuildingNumber());

            var locations = locationFaker.Generate(100);

            var userFaker = new Faker<User>()
                .RuleFor(d => d.Name, f => f.Person.FullName)
                .RuleFor(d => d.Location, f => f.PickRandom(locations));

            var users = userFaker.Generate(100);
            users.Add(
                new User("Rusu Vlad", true, locationFaker.Generate()));

            dbContext.Devices.AddRange(devices);
            dbContext.Users.AddRange(users);
            dbContext.SaveChanges();
        }
    }
}
