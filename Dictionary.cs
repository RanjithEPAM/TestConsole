using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Dictionary
    {
        public void dict()
        {
            Dictionary<string, int> StudentAge = new Dictionary<string, int>();
            StudentAge.Add("Jones", 24);
            StudentAge.Add("Jack", 32);
            StudentAge.Add("Will", 15);
            StudentAge.Add("Smith", 40);
            Console.WriteLine("Count is - " + StudentAge.Count);
            foreach (var item in StudentAge)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
                if (item.Value > 30)
                {
                    StudentAge[item.Key]++;
                    Console.WriteLine("\n" + item.Key + " - " + item.Value);
                }
                if (StudentAge.ContainsKey("Will"))
                {
                    StudentAge["Will"]++;
                    Console.WriteLine("\n" + item.Key + " - " + item.Value);
                }
            }
        }
    }
}
