using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class Car : IVehicle
    {
        private readonly int wheels;
        public Car() 
        {
            this.wheels = 4;
        }
        public string VehicleType()
        {
            return "Car";
        }

        public int NumberOfWheels()
        {
            return this.wheels;
        }


    }
}
