//using System;
//using System.Collections.Generic;
//using System.Data.SqlTypes;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//
//{
//    internal class ArrayActivity
//    {
//        public static void Main()
//        {
//            int[] num = new int[] { 1, 2, 3, 4, 5 };
//            Console.WriteLine(num[0]);
//        }

//    }
//}

using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
namespace DotNET_Experiments
{
    class ArrayActivity
    {
        private string color = "White";
        private int maxSpeed = 200;

        public string getColor
        {
            get { return color; }
        }

        public int getMaxSpeed
        {
            get { return maxSpeed; }
        }

        //ways to create array
        //1. string[] cars = new string[4];
        //2. string[] cars = new string[4]{"Volvo", "BMW", "Creata","Ford"};
        //3. string[] cars = new string[]{"Volvo", "BMW", "Creata","Ford"};
        //4. string[] cars = {"Volvo", "BMW", "Creata","Ford"};
        //5. string[] cars;
        //cars = new string[]{"Volvo", "BMW", "Creata","Ford"};
        
        public void displayArray()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void loops()
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine("foreach loop:");
            foreach (int i in arr)
            {
                Console.WriteLine( i );
            }   
        }

        public void sorting()
        {
            Console.WriteLine("Sorting array : ");
            int[] arr = new int[]{ 15, 26, 12, 05, 10 };
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void helpingMethods()
        {
            Console.WriteLine("Helping methods : ");
            int[] arr = { 10, 15, 20, 25, 30, 35, 40 };
            Console.WriteLine("Max element : " + arr.Max());
            Console.WriteLine("Min element : " + arr.Min());
            Console.WriteLine("Sum of element : " + arr.Sum());
        }

        //2 dimentional array
        public void twoDimentionArray()
        {
            int[,] nums = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("forEach loop : ");
            foreach (var i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("for loop : ");
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for(int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.WriteLine(nums[i, j] + " ");
                }
            }
        }
    }
}


