using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class BaseClass
    {
        public string firstName = "James";
        public string lastName = "Anderson";
        public int age = 25;

        public int SSN { get; set; }

        public string ReturnUserName()
        {
            return firstName + " " + lastName;
        }
    }

    public class DerivedClass : BaseClass
    {
        public void printUserAge()
        {
            Console.WriteLine("User age is " + age);
        }
        public void printUserSSN() 
        {
            SSN = 123456789;
            Console.WriteLine(SSN);
        }
    }

    public class DerivedClass2 : DerivedClass 
    {
        public long userPhoneNUmber = 9994441234;

        public string UserAddress = "Complete Address";
        public void PrintUserAddress()
        {
            Console.WriteLine(UserAddress);
        }
    }
}