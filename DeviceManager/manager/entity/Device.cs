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
        private uint _id;
        private string name;
        private string manufacturer;
        private Type type;
        private string os;
        private string processor;
        private int ram;
        private string description;

        public static string ReturnType(Type T)
        {
            return T == Type.Phone ? "Phone" : "Tablet";
        }


        public Device() { }

        public Device(string Name, string Manufacturer, Type Type, string Os, string Processor, int Ram, string Description)
        {
            this.name = Name;
            this.manufacturer = Manufacturer;
            this.type = Type;
            this.os = Os;
            this.processor = Processor;
            this.ram = Ram;
            this.description = Description;
        }

        public uint Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public Type Type 
        {
            get { return type; }
            set { type = value; }
        }

        public string Processor { get; set; }

        public string Os {  get; set; }

        public int Ram {  get; set; }

        public string Description {  get; set; }
    }
}
