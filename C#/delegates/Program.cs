using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate void myDelegate();
        public void function1()
        {
            Console.WriteLine("Function1 call()");
        }
        
        public void function2()
        {
            Console.WriteLine("function2 call ()");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            myDelegate del = new myDelegate(obj.function1);
            del += obj.function2;
            del();
            

        }
    }
    
}
