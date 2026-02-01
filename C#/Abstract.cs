using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Practice
{
    abstract class Animals
    {
        public abstract void animalSound();

        public void sleep()
        {
            Console.WriteLine("Zzzz!!");
        }

    }
    class Dogs : Animals
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says :  bow wow");
        }
    }
}
