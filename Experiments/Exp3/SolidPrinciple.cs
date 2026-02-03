using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Experiments
{
    //single responsibility principle
    internal class SolidPrinciple
    {   
        public void bakeBread()
        {
            Console.WriteLine("Baking high quality bread ...!!");
        }

    }

    //open/closed principle
    abstract class PaymentProcess {
        public abstract void processPayment(double amount); 
    }

    class CreditCardPayment : PaymentProcess {
        public override void processPayment(double amount)
        {
            Console.WriteLine("The credited amount is : " + amount);
        }
    }

    //Liskov's Substitution Principle
    class Rectangle
    {
        protected int width;
        protected int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public virtual int Width //property
        {
            get { return width; }
            set { width = value; }
        }

        public virtual int Height
        {
            get { return height; }
            set { height = value;  }
        }

        public int area()
        {
            return height * width;
        }


    }

    class Square : Rectangle
    {
        public Square(int size) : base(size, size)
        {
            
        }

        public override int Width
        {
            get { return base.width; }
            set { base.width = value; }
        }

        public override int Height
        {
            get { return base.height; }
            set { base.height = value;  }
        }


    }

    //Interface segregation principle
    interface IVegMenu
    {
        List<String> getVegItems();
    }

    interface INonVegMenu
    {
        List<String> getNonVegItems();
    }

    class VegMenu : IVegMenu
    {
        public List<String> getVegItems()
        {
            return new List<String> { "vegetable curry", "Kaju masala", "Salad" };
        }
    }

    class NonVegMenu : INonVegMenu
    {
        public List<String> getNonVegItems()
        {
            return new List<String> { "Chiken curry ", "Fish curry", "Chilly Chiken" };
        }
    }


    //dependancy inversion principle
    interface IVersionControl
    {
        void commit(string message);
        void push();
        void pull();
    }

    class GitVersionControl : IVersionControl
    {
        public void commit(string message)
        {
            Console.WriteLine("Commiting changes with message: " + message);
        }

        public void push()
        {
            Console.WriteLine("Pushing changes to remote git repository");
        }

        public void pull()
        {
            Console.WriteLine("Pulling changes from remote git repository");
        }
    }

    class DevelopmentTeam
    {
        private IVersionControl vc;

        public DevelopmentTeam(IVersionControl vc1) 
        {
            vc = vc1;
        }

        public void makeCommit(string message)
        {
            vc.commit(message);
        }

        public void performPush()
        {
            vc.push();
        }

        public void performPull()
        {
            vc.pull();
        }
    }

}
