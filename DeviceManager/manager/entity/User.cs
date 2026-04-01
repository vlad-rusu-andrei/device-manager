using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.entity
{
    public class Location
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public Location() {}

        public Location(string city, string street, string number)
        {
            City = city;
            Street = street;
            Number = number;
        }
    }

    public class User
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public bool Role { get; set; }

        public Location Location { get; set; }

        public User() { }

        public User(string name, bool role, Location location)
        {
            Name = name;
            Role = role;
            Location = location;
        }
    }
}
