using System;

class Program{
    public static void greeting(string str){
        Console.WriteLine("Hello " + str);
    }

    public static int add(int a, int b){
        return a + b;
    }

    //passing as many arguments using params
    public static void sum(params int[] numbers){
        int s = 0;
        foreach(int i in numbers){
            s += i;
        }
        Console.WriteLine("Sum is : "+ s);
    }

    //names arguments
    public static void MyMethod(string s1 , string s2, string s3){
        Console.WriteLine("The youngest chiid is : "+ s3);
    }

    //method overloading
    public static int sub(int a, int b){
        return a - b;
    }

    public static float sub(float a, float b){
        return a - b;
    }

    public static void Main(string[] args){
        greeting("Siddhi");

        Console.WriteLine("Addition : " + add(5, 10));
        // Console.WriteLine("Addition : " + add(5, 10, 15)); //error because we should pass same no of arguments
        // Console.WriteLine("Addition: "+ add(5)); //error


        //when we write params in the function parameter then we can pass as many arguments as we want
        Console.WriteLine("params: ");
        sum(10, 20);
        sum(10, 20, 30, 40);
        sum(1);

        Console.WriteLine("Names parameters: ");
        MyMethod(s3 : "Swara", s1 : "Riddhi", s2 : "Siddhi");

        Console.WriteLine("Method overloading : ");
        Console.WriteLine("Integert subtraction: " + sub(10, 5));
        Console.WriteLine("Float subtraction : " + sub(10.5F, 5.5F));
    }
}