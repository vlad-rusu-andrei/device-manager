using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.entity
{
    public enum Type
    {
        Phone,
        Tablet
    }

    public class Device
    {
        public uint Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public Type Type{ get; set; }

        public string Processor { get; set; }

        public string Os { get; set; }

        public string Osversion { get; set; }

        public int Ram { get; set; }

        public string Description { get; set; }

        public static string ReturnType(Type T)
        {
            return T == Type.Phone ? "Phone" : "Tablet";
        }


        public Device() { }

        public Device(string name, string manufacturer, Type type, string os, string osversion, string processor, int ram, string description)
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
