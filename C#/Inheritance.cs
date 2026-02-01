using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Practice
{
    internal class Inheritance
    {
            private string brand = "Ford";

            public string Brand
            {
                get { return brand;}
            }

            public void horn()
            {
                Console.WriteLine("Tuut, Tuut!!");
            }
        
    }
    class Vehicle: Inheritance
    {
        public string modelName = "Mustang";

        public string ModelName
        {
            get { return modelName; }
        }
    }
}
