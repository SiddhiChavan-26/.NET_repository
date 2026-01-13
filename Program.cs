class Program{

    //Function to check whether the number is prime or not
    static bool Prime(int number){
        if(number <= 1)
            return false;

        for(int i = 2; i <= number / 2; i++){
            if(number % i == 0)
                return false; 
        }
        return true;
    }

    //Function to check whether the user can vote or not
    static void isVoter(int age){
        if(age >= 18)
            System.Console.WriteLine("Can Vote");
        else   
            System.Console.WriteLine("Can not Vate");
    }
    

    public static void Main(){
            //check whether the number is prime or not 
            int num1 = 10;
            int num2 = 11;

            if(Prime(num1)){
                System.Console.WriteLine("Num1 is Prime number");
            }else{
                System.Console.WriteLine("Num1 is not a Prime number");
            }

            if(Prime(num2)){
                System.Console.WriteLine("Num2 is Prime number");
            }else{
                System.Console.WriteLine("Num2 is not a Prime number");
            }

            //check whether user can vote or not 
            int AGE = 20;
            isVoter(AGE);
    }
    
}