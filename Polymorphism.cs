using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    internal class Overload : Override
    {
        public void addition(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("sum is : " + sum);
        }
        public void addition(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("sum is : " + sum);
        }
        public override void MethodPrint()
        {
            Console.WriteLine("This is RunTime polymorphism");
        }

    }

    internal class Override
    {
        public virtual void MethodPrint()
        {
            Console.WriteLine("This is polymorphism");
        }

    }
}
