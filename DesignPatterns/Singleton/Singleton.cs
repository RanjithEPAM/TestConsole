using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static int counter = 0;
        private Singleton()
        {
            counter++;
            Console.WriteLine(counter.ToString());
            // to avoid instance creation from outside the class.   
        }
        private static Singleton? objInstance;
        private static readonly object myLockObject = new object();
        public static Singleton getInstance()
        {
            lock (myLockObject)
            {
                if (objInstance == null)
                {
                    objInstance = new Singleton();
                }
            }

            return objInstance;
        }

        public string book1Details()
        {
            return "Book name is - Testing Basics";
        }
        public string book2Details()
        {
            return "Book name is - Testing Advanced";
        }
    }
}