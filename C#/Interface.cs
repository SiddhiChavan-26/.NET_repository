using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Practice
{
    interface IAnimal
    {
        void animalSound();
    }

    class cats : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The cat says : meow meow");
        }
    }
}
