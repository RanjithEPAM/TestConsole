﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public interface IVehicle
    {
        void Method1();
    }

    public interface IAnimal
    {
        void Method2();
    }

    public class Car : IAnimal, IVehicle
    {
        public void Method1()
        {
            Console.WriteLine("This is Method from Interface IVehicle");
        }
        public void Method2()
        {
            Console.WriteLine("This is Method from Interface IAnimal");
        }
       
    }
}
