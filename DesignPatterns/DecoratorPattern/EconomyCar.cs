using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class EconomyCar : ICarDeco
    {
        public double GetCost()
        {
            return 450000.0;
        }

        public string GetDescription()
        {
            return "Economy Car";
        }
    }
}
