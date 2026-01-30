class Arithmetic{
    public static void Main(){
        int num1 = 20;
        int num2 = 10;

        System.Console.WriteLine("Addition : " + (num1+num2));
        System.Console.WriteLine("Subtraction: " + (num1-num2));
        System.Console.WriteLine("Multiplication : " + (num1*num2));
        System.Console.WriteLine("Division : " + (num1/num2));
        System.Console.WriteLine("Modulus : " + (num1%num2));

        //Type Casting
        //When converting smaller type into larger type -> no need of casting
        int num = 15;
        double num_double = num;

        System.Console.WriteLine("num : " + num + "type of num : "+ num.GetType());
        System.Console.WriteLine("num_double : "+ num_double + "type of num_double : " + num_double.GetType());

        double d = 15.26;
        int d_num = (int)d;
        System.Console.WriteLine("d : " + d + " type of d : " + d.GetType());
        System.Console.WriteLine("d_num : " + d_num + " type of d_num : " + d_num.GetType());

        bool value = true;
        string str = string(value);
        System.Console.WriteLine("value : " + value + "type of value :" + value.GetType());
        System.Console.WriteLine("str: " + str + "type of str :" + str.GetType());


    }
}