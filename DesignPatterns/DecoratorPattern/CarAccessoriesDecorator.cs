using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class CarAccessoriesDecorator : ICarDeco
    {
        private ICarDeco _carDeco;

        public CarAccessoriesDecorator(ICarDeco carDeco)
        {
            this._carDeco = carDeco;
        }

        public virtual double GetCost()
        {
            return this._carDeco.GetCost();
        }

        public virtual string GetDescription()
        {
            return this._carDeco.GetDescription();
        }
    }
}