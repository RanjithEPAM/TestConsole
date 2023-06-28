using OpenQA.Selenium.DevTools.V110.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Examples;

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

        public void LINQValidation()
        {
            IList<Student> students = new List<Student>()
            {
                new Student() { Name = "Kumar", Id = 1008, Age = 23},
                new Student() { Name = "James", Id = 1003, Age = 26},
                new Student() { Name = "Gayle", Id = 1001, Age = 32},
                new Student() { Name = "Chris", Id = 1005, Age = 32},
                new Student() { Name = "Gayle", Id = 1006, Age = 32},
                new Student() { Name = "Jones", Id = 2005, Age = 32},
                new Student() { Name = "Gayle", Id = 1006, Age = 32},
                new Student() { Name = "Jones", Id = 2005, Age = 32}
            };

            var result1 = students.First();
            Console.WriteLine("First");
            Console.WriteLine(result1.Name);
            result1 = students.Last();
            Console.WriteLine("Last");
            Console.WriteLine(result1.Name);
            var resTest = students.OrderBy(x => x.Name).First();
            var resTest1 = students.Where(sd =>sd.Name.StartsWith("T"));
            var result11 = students.Where(ss => ss.Age > 35 && ss.Id > 2000);
            foreach (var res in result11)
            {
                Console.WriteLine(res.Name);    
            }
            var result12 = students.Where(ss => ss.Name.StartsWith("J") || ss.Name.EndsWith("s")).Take(3);
            foreach (var res in result12)
            {
                Console.WriteLine(res.Name);
            }
            Console.WriteLine("$$$$$$$$$$");
            int num = students.Min(ss => ss.Age);

            Console.WriteLine(num);

            var result13 = students.OrderBy(F => F.Age).ThenBy(r => r.Id).GroupBy(S => S.Name);
            var result14 = students.OrderByDescending(F => F.Age).ThenBy(r => r.Id);
            Console.WriteLine("Sorted");
            foreach (var rest in result13)
            {
                Console.WriteLine(rest.Key + "\t" );
                foreach (var tt in rest)
                {
                    Console.WriteLine(tt.Name + "\t" + tt.Age + "\t" + tt.Id);
                }
            }
            IEnumerable<Student> restut20 = students.Reverse();
            Console.WriteLine("Distinct *******");
            var result55 = students.Distinct();
            foreach (var ii in result55)
            {
                Console.WriteLine(ii.Id);
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
            Console.WriteLine("Query check *********************");

            var newresult = students.Where(s => s.Name.StartsWith("J") || s.Name.EndsWith("s"));
            foreach (var se in newresult)
            {
                Console.WriteLine(se.Name);
            }
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

            // To Dictionary
            var studentCount = students.Count(s => s.Age >= 30);
            Console.WriteLine(studentCount.ToString()); 

            var studDict = students.ToDictionary(x=>x.Id,x => x.Age);

            foreach(var k in studDict)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }

            //Join
            IList<StudentList> studentList  = new List<StudentList>()
            {
                new StudentList() { StudentID =2001, StudCity = "Karur", StudName = "Kumar"},
                new StudentList() { StudentID = 2002, StudCity = "Delhi", StudName = "Raj" },
                new StudentList() { StudentID = 2003, StudCity = "Chennai", StudName = "Chris" }
            };
            IList<StandardList> stdList = new List<StandardList>()
            {
                new StandardList() { StudentID = 2001, StudentRank = 1,},
                new StandardList() { StudentID = 2002, StudentRank = 3, },
                new StandardList() { StudentID = 2003, StudentRank = 2, }
            };

            var innerJoin = studentList.Join(
                stdList,
                St => St.StudentID,
                Sd => Sd.StudentID,
                (St, Sd) => new
                {
                    StName = St.StudName,
                    SdRank = Sd.StudentRank
                });
            foreach(var ss in innerJoin)
            {
                Console.WriteLine("This is Inner Join");
                Console.WriteLine(ss.StName+ " - " + ss.SdRank);
            }
        }
    }
}