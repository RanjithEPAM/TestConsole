using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Examples
{
    public partial class Employee
    {
        public Employee(int id, string name)
        {
            this.id = id;
            this.Name = name;
        }

        public void displayInfo()
        {
            Console.WriteLine("ID - " + id + "Name - " + Name);
        }
    }

}
