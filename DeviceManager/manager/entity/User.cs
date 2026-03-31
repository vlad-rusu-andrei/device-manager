using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.entity
{
    public class Location
    {
        string City;
        string Street;
        uint Number;
    }

    public class User
    {
        private uint _id;
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

        public uint Id { get; set; }

        public string Name { get; set; }

        public bool Role {  get; set; }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
