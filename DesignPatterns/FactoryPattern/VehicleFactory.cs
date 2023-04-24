using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicleType(string type)
        {
            IVehicle ObjectType = null;
            if(type.ToLower().Equals("bike"))
            {
                ObjectType = new Bike();
            }
            else if(type.ToLower().Equals("car"))
            {
                ObjectType = new Car();
            }
            else if (type.ToLower().Equals("autorickshaw"))
            {
                ObjectType = new AutoRickshaw();
            }
            return ObjectType;
        }
    }
}