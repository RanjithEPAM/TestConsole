using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICarDeco acarDeco) : base(acarDeco)
        {
        }
            public override string GetDescription()
        {
            return base.GetDescription() + ",Advanced Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 10000.0;
        }
    }
}
