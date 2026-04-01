using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.dto
{
    public class DeviceDTO
    {
        public uint Id { get; set; }

        public string? Name { get; set; }

        public string? Manufacturer { get; set; }

        public entity.Type? Type { get; set; }

        public string? Processor { get; set; }

        public string? Os { get; set; }

        public string? Osversion { get; set; }

        public int? Ram { get; set; }

        public string? Description { get; set; }

        public DeviceDTO() { }

        public DeviceDTO(string name, string manufacturer, entity.Type type, string os, string osversion, string processor, int ram, string description)
        {
            Name = name;
            Manufacturer = manufacturer;
            Type = type;
            Os = os;
            Osversion = osversion;
            Processor = processor;
            Ram = ram;
            Description = description;
        }
    }
}
