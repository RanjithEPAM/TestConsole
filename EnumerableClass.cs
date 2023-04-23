using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Customers
    {
        public string Name;
        public int ID;
        public bool Validity;


        Customers[] customer = new Customers[]
        {
            new Customers { Name = "Chris", ID = 1001, Validity = true },
            new Customers { Name = "Kevin", ID = 1002, Validity = false }
        };

        public IEnumerable<Customers> GetAllCustomers()
        {
            return customer;
        }
    }
    public class sample : Customers 
    {
        public void Method1()
        {
            foreach(var s in GetAllCustomers())
            {
                Console.WriteLine(s.Name + " - " + s.ID + " - " + s.Validity);
            }
        }
    }
}