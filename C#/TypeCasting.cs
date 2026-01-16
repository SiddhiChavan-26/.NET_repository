class TypeCasting{
    public static void Main(){
        int num = 15;
        double num_double = num;

        System.Console.WriteLine("num : " + num + " typeof num : " + num.GetType());
        System.Console.WriteLine("num_double : " + num_double + " typeof _double : " + num_double.GetType());

        System.Console.WriteLine();
        double num1 = 9.78;
        int num1_int = (int)num1;
        System.Console.WriteLine("num1 : " + num1 + " typeof num1 : " + num1.GetType());
        System.Console.WriteLine("num1_int : " + num1_int + " typeof num1_int : " + num1_int.GetType());

    
        System.Console.WriteLine();
        System.Console.WriteLine("Type casting methods :");
        int var = 10;
        double myDouble = 15.26;
        bool value = false;

        System.Console.WriteLine(System.Convert.ToString(var) + " typeof var : " + var.GetType());
        System.Console.WriteLine(System.Convert.ToDouble(var) + " typeof var : " + var.GetType());
        System.Console.WriteLine(System.Convert.ToInt32(myDouble) + " typeof myDouble : " + myDouble.GetType());
        System.Console.WriteLine(System.Convert.ToString(value) + " typeof value : " + value.GetType());
    }
}