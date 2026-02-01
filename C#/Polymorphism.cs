using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Practice
{   
    //to override the base class method in the derived class use the virtual keyword in the base class method
    //if we do not use virtual keyword then the base class method overrides the derived classs method means base class method is called 
    //to override the base class method in the derived class use override keyword in the derived class
    //to achieve method overriding must use virtual and override keywords 
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes sound.");
        }
    }
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says : meaw meaw");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says : bow wow");
        }
    }
}
