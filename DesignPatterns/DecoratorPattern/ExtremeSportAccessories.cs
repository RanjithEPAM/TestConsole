using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class ExtremeSportAccessories : CarAccessoriesDecorator
    {
        public ExtremeSportAccessories(ICarDeco acarDeco) : base(acarDeco)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + ",Extreme Sport Accessories";
        }
        public override double GetCost()
        {
            return base.GetCost() + 25000;
        }

    }
}
