using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Lists
    {
        public void StudentsList()
        {
            List<string> studentNames = new List<string>();
            studentNames.Add("James");
            studentNames.Add("Kumar");
            studentNames.Add("Kevin");
            studentNames.Add("Chris");

            Console.WriteLine("Capacity is - " + studentNames.Capacity);
            Console.WriteLine("Count is - " + studentNames.Count);

            studentNames.Sort();

            foreach (string s in studentNames) 
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(studentNames.IndexOf("Kumar"));
            string[] names = studentNames.ToArray();
            foreach(var s in names) { Console.WriteLine(s);}
            
            ArrayList arrList = new ArrayList();
            arrList.AddRange(names);
            foreach (var s in arrList) 
            {
                Console.WriteLine(s);
            }
            arrList.Clear();
        }

        
        
    }
}
