using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Laptop
{
    public class Laptop : IProduct
    {
        string _additionalDevices = string.Empty;
        string _processor = string.Empty;
        string _storage = string.Empty;
        string _memory = string.Empty;
        public void AdditionalDevices()
        {
            _additionalDevices = "Bluetooth keyboard and mouse";
        }

        public void setMemory(string memory)
        {
            _memory = memory;
        }

        public void setProcessor(string processor)
        {
            _processor = processor;
        }

        public void setStorage(string storage)
        {
            _storage = storage;
        }

        public void Shwodetails()
        {
            Console.WriteLine("Laptop configuration: " + _processor + " " + _storage + " - " + _memory);
        }
    }
}

