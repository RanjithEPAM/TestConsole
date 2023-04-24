using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class DeluxeCar : ICarDeco
    {
        public double GetCost()
        {
            return 750000.0;
        }

        public string GetDescription()
        {
            return "Deluxe Car";
        }
    }
}
