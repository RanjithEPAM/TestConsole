using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Learn
{
    public interface IAnimal11
    {
        void animalSound();
    }

    public class Dog : IAnimal11
    {
        public void animalSound()
        {
            Console.WriteLine("This is dog sound");
        }
    }

    public class Cat : IAnimal11
    {
        public void animalSound()
        {
            Console.WriteLine("This is cat sound");
        }
    }
}