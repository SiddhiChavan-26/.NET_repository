using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {   

        static async Task Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Console.ReadLine(); //hold execution 
            //to hold the console text or the console values so all text remain on console one after another as the method executes
            //if we do not write Console.ReadLine() then it shows improper behaviour  the output will not be displayed properly 

            //Activty 4 
            Console.WriteLine();
            Console.WriteLine("Activity 4 : ");
            Console.WriteLine("Main started...");

            await DoWorkAsync();
            //if our main is synchronous so we cannot use await so then we can use .Wait() or .GetAwaiter().GetResult()

            

            //calling async method with return type 
            int result = await AddNumbersAsync();  
            //if the main is not async we have to write AddNumbersAsync().Result --> that extracts the integer value after task completes.
            Console.WriteLine("result : " + result);

            Console.WriteLine("Main finished");
        }

        //asyc method returning task
        static async Task DoWorkAsync()
        {
            Console.WriteLine("Work started..");
            await Task.Delay(3000);
            Console.WriteLine("Work finished.");
        }

        //method returning int value 
        static async Task<int> AddNumbersAsync()
        {
            await Task.Delay(1000);
            return 10 + 20;
        }

        public async static void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 starting.");
                //Thread.Sleep(3000);
                Task.Delay(3000);
                Console.WriteLine("Task1 execute");
            }); 
        }

        public async static void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 starting");
                //Thread.Sleep(4000);
                Task.Delay(4000);
                Console.WriteLine("Task2 execute");
            });
        }

        public async static void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 starting");
                //Thread.Sleep(2000);
                Task.Delay(2000);
                Console.WriteLine("Task3 execute");
            });
        }

        public async static void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task4 starting");
                //Thread.Sleep(1000);
                Task.Delay(1000);
                Console.WriteLine("Task4 execute");
            });
        }

        public async static void Task5()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task5 starting");
                //Thread.Sleep(7000);
                Task.Delay(7000);
                Console.WriteLine("Task5 execute");
            });
            
        }

        public async static void Task6()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task6 starting");
                //Thread.Sleep(4000);
                Task.Delay(4000);
                Console.WriteLine("Task6 execute");
            });
        }

    }
}

//Activity 1 - run program sybnchronously 
//activity 2 - same code asynchronously and observe time 
//Activity 3 - replace thread.sleep with task.delay and observe bheaviour
//Activity 4 - create method and returning task