using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Practice
{
    interface IFirstInterface
    {
        void myMethod();
    }

    interface ISecondInterface
    {
        void myOtherMethod();
    }

    class DemoClass
    {
        public void myMethod()
        {
            Console.WriteLine("Some text from myMethod()");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Some text from myOtherMethod()");
        }
    }
}
