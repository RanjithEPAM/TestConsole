using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Linq
    {
        public void listValidation()
        {
            List<string> list = new List<string>();
            list.Add("Orange");
            list.Add("Blue");
            list.Add("Green");
            list.Add("Yellow");
            list.Add("Pink");

            var result = list.OrderBy(s => s);
            foreach(var f in result)
            {
                Console.WriteLine(f);
            }
        }
        public void StudentListValidation()
        {
            IList<Student> students = new List<Student>()
            {
                new Student() { Name = "Kumar", Id = 1008, Age = 23},
                new Student() { Name = "James", Id = 1003, Age = 26},
                new Student() { Name = "Gayle", Id = 1001, Age = 32},
                new Student() { Name = "Chris", Id = 1005, Age = 34}
            };
            var result = students.OrderBy(s => s);
            Console.WriteLine("Query check");
            var res = students.Where(s => s.Age > 30);
            foreach(var s in res)
            {
                Console.WriteLine(s.Name + " - " +  s.Id + " " + s.Age);
            }
            var res1 = students.Select(s => s.Name.Contains("e"));
            
            foreach(var sy in res1)
            {
                //Console.WriteLine(sy);
            }


            var studentCount = students.Count(s => s.Age >= 30);
            Console.WriteLine(studentCount.ToString());
        }
    }
}