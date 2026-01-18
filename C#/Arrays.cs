using System;
using System.Linq;

class Arrays{
    public static void Main(){
        string[] cars = {"Volvo", "BMW", "Ford", "Ritz"};
        Console.WriteLine(cars[0]);

        // //methods of declaring array
        // string[] cars = new string[4];
        // string[] cars = new string[4] {"Volvo", "BMW" "Ford", "Mazda"};
        // string[] cars = new string[]{"Volvo", "BMW" "Ford", "Mazda"};
        // string[] cars = {"Volvo", "BMW" "Ford", "Mazda"};
        // string[] cars;
        // cars = new string[] {"Volvo", "BMW" "Ford", "Mazda"};

        //for loop
        Console.WriteLine("For loop : ");
        for(int i = 0; i < cars.Length; i++){
            Console.WriteLine(cars[i]);
        }
        Console.WriteLine();

       Console.WriteLine("foreach loop : ");
        foreach(string i  in cars){
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine("sort array using Sort() : ");
        int[] numbers = {5, 1, 8, 9};
        Array.Sort(numbers);
        foreach(int i in numbers){
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine("System.Linq methods() : ");
        Console.WriteLine("Max : " + numbers.Max());
        Console.WriteLine("Min : " + numbers.Min());
        Console.WriteLine("Sum : " + numbers.Sum());
        Console.WriteLine();

        Console.WriteLine("MultiDimentional array : ");
        int[ , ] num = {{1,2,3}, {4,5,6}};
        Console.WriteLine(num[0, 1]);
        Console.WriteLine();

        Console.WriteLine("foreach loop : ");
        foreach(int i in num){
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine("for loop and GetLength() : ");
        for (int i = 0; i < num.GetLength(0); i++) { 
            for (int j = 0; j < num.GetLength(1); j++){ 
                Console.WriteLine(num[i, j]); 
            } 
        } 
    }
    
        
}



