using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class ArraList
    {
        public void CheckArraList()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add("Testing");
            arrList.Add(123);
            arrList.Add(true);
            arrList.Add(123231231232);

            foreach(var s in arrList) 
            {
                Console.WriteLine(s);
            }

        }
    }
}
