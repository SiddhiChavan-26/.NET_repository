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

        public static void displayVegMenu(IVegMenu menu)
        {
            Console.WriteLine("Vegeterian menu : ");
            foreach (var item in menu.getVegItems())
            {
                Console.WriteLine("-" + item);
            }
        }

        public static void displayNonVegMenu(INonVegMenu m)
        {
            Console.WriteLine("Non vegeterian menu : ");
            foreach (var items in m.getNonVegItems())
            {
                Console.WriteLine("-" + items);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            //Console.WriteLine("Experiment no : 2")
            //ArrayActivity ar1 = new ArrayActivity();
            //Console.WriteLine("Color : " + ar1.getColor);
            //Console.WriteLine("MaxSpeed : " + ar1.getMaxSpeed);

            //Console.WriteLine("1D Array ---> ");
            //ar1.displayArray();
            //ar1.loops();
            //ar1.sorting();
            //ar1.helpingMethods();

            //Console.WriteLine("2D Array ---> ");
            //ArrayActivity ar2 = new ArrayActivity();
            //ar2.twoDimentionArray();

            //Console.WriteLine();
            //Console.WriteLine("Experiment no : 3");
            //Console.WriteLine();
            //Console.WriteLine("Single Responsibility Principle : ");
            //SolidPrinciple s1 = new SolidPrinciple();
            //s1.bakeBread();

            //Console.WriteLine();
            //Console.WriteLine("Open/Closed principle : ");
            //CreditCardPayment c1 = new CreditCardPayment();
            //c1.processPayment(4000);


            //Console.WriteLine();
            //Console.WriteLine("Liskov's substitution principle : ");
            //Square sq1 = new Square(5);
            //Console.WriteLine("The area of the square is : " + sq1.area()); //area = 25 --> 5 * 5
            //sq1.Width = 10; //here we changed the width of the square so the area also chnages
            //Console.WriteLine("The area of the square is : " + sq1.area()); //area = 50 --> 5 * 10


            //Interface segregation principle
            //Console.WriteLine();
            //Console.WriteLine("interface Segregation principle : ");

            //VegMenu v1 = new VegMenu();
            //NonVegMenu nv1 = new NonVegMenu();

            //displayVegMenu(v1);
            //displayNonVegMenu(nv1);


            //Dependancy Inversion principle
            //Console.WriteLine();
            //Console.WriteLine("Dependancy Inversion principle : ");
            //GitVersionControl git = new GitVersionControl();
            //DevelopmentTeam d1 = new DevelopmentTeam(git);

            //d1.makeCommit("Initial Commit");
            //d1.performPush();
            //d1.performPull();


            //activity ---> how to connect C# to Adv .net connnectivity 


            //Experiment no 4
            //DelegateExample del1 = new DelegateExample();
            Console.WriteLine();
            Console.WriteLine("Experiment no: 4");
            DelegateExample.perform();

            Console.WriteLine();
            Console.WriteLine("Activity 1: Arithmetic operations (+, -, *, /");
            DelegateExample.DelegateWithReturn();

            Console.WriteLine();
            Console.WriteLine("Activity 2 : Muticast delegate example");
            DelegateExample.multiCastDelegate();

            Console.WriteLine();
            Console.WriteLine("Activity 3 : Replace method with lambda expression");
            DelegateExample.lambdaExpression();

            Console.WriteLine();
            Console.WriteLine("Activity 4 : Sort list using lambda expression");
            DelegateExample.SortList();

            Console.WriteLine();
            Console.WriteLine("Activity 6 : Linq example");
            DelegateExample.linqExample();

        }
    }
}
