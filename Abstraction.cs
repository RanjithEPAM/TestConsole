using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public abstract class Students
    {
        public string name = "Peterson";

        public int rollNo = 10001;

        public void printName()
        {
            Console.WriteLine("Name is " + name);
        }
        public abstract void printRollNo();
    }

    public class School : Students
    {
        public override void printRollNo()
        {
            Console.WriteLine("Roll Number is " + rollNo);
        }
    }
}