using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class AccessModifiers
    {
        public const double pi = 3.14;

        public readonly long phoneNumber;

        public AccessModifiers()
        {
            phoneNumber = 9994441234;
        }

        public string name1 = "Peterson";
        public int id1 = 1001;

        private string name2 = "David";
        private int id2 = 1001;

        protected string name3 = "Will";
        protected int id3 = 1004;

        public void Method1()
        {
            Console.WriteLine("This is method1");
        }
        
        protected void Method3()
        {
            Console.WriteLine("This is method1");
        }
        public void ReadConstant()
        {
            Console.WriteLine("PhoneNumber is - " + phoneNumber);
        }
    }
    public class TestSample : AccessModifiers
    {
        public void TryMethod()
        {
            Method1 ();
            Method3();
            Console.WriteLine(name1);
            Console.WriteLine(name3);
        }
    }
}