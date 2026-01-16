class UserInput{
    public static void Main(){
        System.Console.WriteLine("Enter your name : ");
        string name = System.Console.ReadLine();
        System.Console.WriteLine("Your name : " + name);

        //Console.ReadLine() returns string to when user enter other data types then we have to use type casting
        System.Console.WriteLine("Enter your age : ");
        int age = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Your age : " + age);


    }
}