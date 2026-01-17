class strings{
    public static void Main(){
        string txt = "Hello world!!";
        System.Console.WriteLine(txt);
        System.Console.WriteLine();

        //methods
        System.Console.WriteLine("ToUpper() method : ");
        string upper =  txt.ToUpper();
        System.Console.WriteLine(upper);
        System.Console.WriteLine();

        System.Console.WriteLine("ToLower() method : ");
        string lower = txt.ToLower();
        System.Console.WriteLine(lower);
        System.Console.WriteLine();

        //String concatenation
        System.Console.WriteLine("String concatenation : ");
        string firstName = "Siddhi";
        string lastName = " Chavan";
        string name = firstName + lastName;
        System.Console.WriteLine(name);
        System.Console.WriteLine();

        System.Console.WriteLine("string.Concat() :  ");
        string name1 = string.Concat(firstName + lastName);
        System.Console.WriteLine(name1);
        System.Console.WriteLine();

        //String interpolation
        // System.Console.WriteLine("String interpolation: ");
        // string fName = "John";
        // string lName = "Doe";
        // string name2 = $"My Full name is : {fName} {lName}";
        // System.Console.WriteLine(name2);
        // System.Console.WriteLine();
        //This code gave error because maybe the version is below the version 6

        //Accessing string
        System.Console.WriteLine("Get Specific chracter : ");
        System.Console.WriteLine(name[0]);
        System.Console.WriteLine();

        System.Console.WriteLine("IndexOf(): ");
        System.Console.WriteLine(name.IndexOf("C"));
        System.Console.WriteLine();

        //use of Substring() and IndexOf() together
        System.Console.WriteLine("Substring() : ");
        string NAME = "Siddhi Chavan";
        int charPos = NAME.IndexOf("C");
        string lastNAME = NAME.Substring(charPos);
        System.Console.WriteLine(lastNAME);
        System.Console.WriteLine();

        //Special characters
        System.Console.WriteLine("Special characters : ");
        string str1 = "We are the so-called \"Vikings\" from the north";
        string str2 = "It\'s alright.";
        string str3 = "The character \\ is called backslash";
        System.Console.WriteLine(str1);
        System.Console.WriteLine(str2);
        System.Console.WriteLine(str3);
        System.Console.WriteLine();

    }
}