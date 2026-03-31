using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.entity
{
    struct Location
    {
        string City;
        string Street;
        uint Number;
    }

    internal class User
    {
        private string name;
        private bool role = false; // normally a user
        private Location location;

        public User() { }

        public User(string Name, bool Role, Location Loc)
        {
            this.name = Name;
            this.role = Role;
            this.location = Loc;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Role
        {
            get { return role; }
            set { role = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
