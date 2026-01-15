class Datatypes{
    public static void Main(){
        int num = 1526;
        System.Console.WriteLine("num : " + num + " typeof num : " + num.GetType());
        
        //value of long datatype should be ended with 'L'
        long longNum = 15000000000L;
        System.Console.WriteLine("longNum : " + longNum + " typeof longNum : " + longNum.GetType());

        //value of float datatype should be ended with 'F'
        float floatNum = 5.75F;
        System.Console.WriteLine("floatNum : " + floatNum + " typeof floatNum : " + floatNum.GetType());

        //value of double data type should be ended with 'D'
        double doubleNum  = 19.99D;
        System.Console.WriteLine("doubleNum : " + doubleNum + " typeof doubleNum : " + doubleNum.GetType());

        //scientific numbers
        float f1  = 35e3F;
        double d1 = 12E4D;
        System.Console.WriteLine(f1);
        System.Console.WriteLine(d1);

        bool isFun = true;
        System.Console.WriteLine("isFun : " + isFun + " typeof isFun : " + isFun.GetType());

        char ch = 'S';
        System.Console.WriteLine("ch : " + ch + " typeof ch : " + ch.GetType());

        string name = "Siddhi";
        System.Console.WriteLine("name : " + name + " typeof name : " + name.GetType());


    }
}

