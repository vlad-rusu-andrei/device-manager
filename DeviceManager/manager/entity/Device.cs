using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager.manager.entity
{
    enum Type
    {
        Phone,
        Tablet
    }

    internal class Device
    {
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Processor
        {
            get { return processor; }
            set { processor = value; }
        }

        public string Os
        {
            get { return os; }
            set { os = value; }
        }

        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
