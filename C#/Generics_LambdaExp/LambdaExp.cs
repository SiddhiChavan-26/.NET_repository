using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Lambda
    {
        //delegate for the lambda expression
        public delegate int newDelegate(int a, int b);

        newDelegate del = (a, b) =>
        {
            return a + b;
        };

        public void displayAddition()
        {
            Console.WriteLine("Addition - " + del(10, 5));
        }
    }
    //Activities 
    
    class Example1
    {
        //filter even numbers
        private List<int> nums = new List<int> { 10, 25, 30, 45, 50, 65};

        public void displayEven()
        {
            List<int> evenNumbers = nums.FindAll(n => n % 2 == 0);

            Console.Write("Even numbers : ");
            foreach (int item in evenNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }

    class Example2
    {
        private List<String> names = new List<String>
        { 
            "Ankita", "Neha", "Rahul", "Akash", "Anuradha", 
        };

        public void displayNamesWithA()
        {
            List<String> result = names.FindAll(name => name.StartsWith("A"));

            Console.Write("Names staring with A : ");
            foreach (String str in result)
            {
                Console.Write(str + " ");
            }
        }
    }

    //Activity 2 - Where we use in company 
    //Data filtering - Companies filter data from large datasets
    //Searching and Sorting Data - Applications frequently sort or search records.
    //Database Queries -Backend developers use lambda expressions to query databases.
    //API Development - Companies return filtered API responses using lambdas.
    //Event Handling & Asynchronous Programming - Lambda expressions simplify callbacks and async operations.

    
    //Activity 3 - Create a generic class and store two values by using lambda expression
    class NewClass<T>
    {
        public T num1;
        public T num2;

        public delegate void StoreDelegate(T a, T b);

        public void StoreValues(T a, T b)
        {
            // Lambda expression
            StoreDelegate store = (x, y) =>
            {
                num1 = x;
                num2 = y;
            };

            store(a, b);
        }
        public void Display()
        {
            Console.Write("Value 1: " + num1);
            Console.Write("  Value 2: " + num2);
        }
    }
    internal class LambdaExp
    {
    }
}
//Activty 1 - write 2 examples with lambda expression 
//Activity 2 - Where we use in company 
//Activity 3 - Create a generic class and store two values by using lambda expression