class Variables{
    public static void Main(){
        int myNum = 5;
        System.Console.WriteLine(myNum);

        myNum = 10;
        System.Console.WriteLine(myNum);

        //when using double should be end with 'D'
        double myDouble = 5.99D;
        System.Console.WriteLine(myDouble);

        //characters are surrounded by single quote
        char letter = 'S';
        System.Console.WriteLine(letter);

        bool value = true;
        System.Console.WriteLine(value);

        //string surrounded by double quotes
        string str = "Siddhi";
        System.Console.WriteLine(str);


        System.Console.WriteLine("CONSTANTS : ");
        const int num = 15;
        System.Console.WriteLine(num);
        // num = 20  ----> this line gives error because the constant value cannot be reassigned


        //display variables
        string firstName = "Siddhi";
        string lastName = "Chavan";
        System.Console.WriteLine(firstName + " " + lastName);

        //multiple variables
        System.Console.WriteLine("Multiple variables: ");
        int x  = 5, y = 10, z = 15;
        System.Console.Write("x : " + x);
        System.Console.Write(" y : " + y);
        System.Console.Write(" z : " + z);

    }
}