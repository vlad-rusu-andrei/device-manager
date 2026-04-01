using DeviceManager.manager.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.dto
{
    public class UserDTO
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
        public Location? Location { get; set; }

        public UserDTO() { }

        public UserDTO(uint id, string name, Location location)
        {
            Id = id;
            Name = name;
            Location = location;
        }
    }
}
