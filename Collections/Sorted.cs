using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Collections
{
    public class Sorted
    {
        
        public void Method1()
        {
            SortedList<string, int> alist = new SortedList<string, int>();
            alist.Add("Raj", 30);
            alist.Add("Kumar", 35);
            alist.Add("Mark", 33);
            foreach(var item in alist)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        public void Method2()
        {
            SortedList alist1 = new SortedList();
            alist1.Add("Kumar", 30);
            alist1.Add("Raj", 22);
            foreach(var item in alist1)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Method3()
        {
            Stack st = new Stack();
            st.Push("Kevin");
            st.Push("Chris");
            st.Push("Peter");
            st.Push("MArk");
            foreach (var s in st)
            {
                Console.WriteLine(s);
            }
            st.Push("John");
            st.Pop();
            foreach (var ss in st)
            {
                Console.WriteLine(ss);
            }
        }
        public void Method4()
        {
            Queue qu = new Queue();
            qu.Enqueue("hello");
            qu.Enqueue("Good");
            qu.Enqueue("Morning");
            qu.Enqueue("Day");
        }
        public void Method5()
        {
            Queue<int> marks = new Queue<int>();

        }

    }
}
