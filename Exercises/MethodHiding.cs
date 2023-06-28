using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Exercises
{
    public class MethodHiding
    {
        public void TestMethod()
        {
            Console.WriteLine("This is a Test Base Method");
        }
        public virtual void TestMethod1()
        {
            Console.WriteLine("This is a Test Base Method1");
        }
    }
}
