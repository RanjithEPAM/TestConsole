using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class KeywordStringOperations
    {
        public string? Sample { get; set; }
        public string? Test { get; set; }
        public void StringMethods()
        {
            Sample = "This is testing";
            Test = "This is good testing";
            Console.WriteLine(Sample + "C#");
            Console.WriteLine(string.Concat(Sample, " in Strings"));
            Console.WriteLine(Test.Equals(Sample));
            Console.WriteLine("This is \"String Operations\" in Testing");
            Console.WriteLine($"This is testing {Sample}");
            Console.WriteLine(Sample.Substring(Sample.Length - 5));
            Console.WriteLine(Sample.Substring(Sample.Length - 5, 3));
            for (int i = 0; i < 128; i++)
            {
               // Console.WriteLine("{0} = {1} \n", i, (char)i);
            }
        }
        public void BreakContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                else if (i == 8)
                {
                    break;
                }
                Console.WriteLine("Iteration - " + i + "This is testing");
            }
        }
    }

    public class Testing : KeywordStringOperations
    {
        public virtual void Method101()
        {
            Console.WriteLine("This is sealed class");
        }

        public virtual void Method102()
        {
            Console.WriteLine("This is sealed class");

        }
    }



    public class work : Testing
    {

        public override void Method101()
        {
            Console.WriteLine("This is sealed class");
        }

        public override sealed void Method102()
        {
            Console.WriteLine("Testing sealed");
        }
    }

    public class stringbuilders
    {
        public void stringBuild()
        {
            StringBuilder sBuilder = new StringBuilder("This is initial string");
            Console.WriteLine(sBuilder);
            sBuilder.AppendLine("\n");
            sBuilder.Append("This is after appending");
            sBuilder.AppendFormat("Testing ");
            sBuilder.Remove(sBuilder.Length - 10, 5);
            Console.WriteLine(sBuilder);
            Console.WriteLine(sBuilder.ToString());
            Console.WriteLine(sBuilder.Length);
        }
    }
}