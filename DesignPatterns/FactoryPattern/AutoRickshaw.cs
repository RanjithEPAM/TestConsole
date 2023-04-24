using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class AutoRickshaw : IVehicle
    {
        private readonly int wheels;
        public AutoRickshaw()
        {
            this.wheels = 3;
        }
        public string VehicleType()
        {
            return "AutoRickshaws";
        }

        public int NumberOfWheels()
        {
            return this.wheels;
        }
    }
}
