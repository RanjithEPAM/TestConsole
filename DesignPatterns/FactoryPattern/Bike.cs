using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class Bike : IVehicle
    {

        private readonly int wheels;
        public Bike() 
        {
            this.wheels = 2;
        }
        public string VehicleType()
        {
            return "Bike";
        }
        public int NumberOfWheels()
        {
            return this.wheels;
        }
    }
}
