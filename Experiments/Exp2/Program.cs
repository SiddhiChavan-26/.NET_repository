using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotNET_Experiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            ArrayActivity ar1 = new ArrayActivity();
            Console.WriteLine("Color : " + ar1.getColor);
            Console.WriteLine("MaxSpeed : " + ar1.getMaxSpeed);

            Console.WriteLine("1D Array ---> ");
            ar1.displayArray();
            ar1.loops();
            ar1.sorting();
            ar1.helpingMethods();

            Console.WriteLine("2D Array ---> ");
            ArrayActivity ar2 = new ArrayActivity();
            ar2.twoDimentionArray();

        }
    }
}
