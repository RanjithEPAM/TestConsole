using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Laptop
{
    public class LaptopBuilder : IBuilder
    {
        Laptop objLaptop;
        public void CreateObject()
        {
            objLaptop = new Laptop();
        }

        public void InitializeObject(string param)
        {
            string[] Params = param.Split(',');
            objLaptop.setStorage(Params[0]);
            objLaptop.setProcessor(Params[1]);
            objLaptop.setMemory(Params[2]);
            objLaptop.AdditionalDevices();
        }

        public IProduct ReturnObject()
        {
            return objLaptop;
        }
    }
}
