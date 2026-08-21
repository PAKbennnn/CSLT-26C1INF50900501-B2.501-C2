using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class ex01
{
    private static void Main(string[] args)
    {
        //1.to Add / Sum Two Numbers.
        int a = 6;
        int b = 9;
        Console.WriteLine(a + b);

        //2.to Swap Values of Two Variables.
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"a = {a}, b =  {b}");

        //3.to Multiply two Floating Point Numbers
        float n1 = 3.5f, n2 = 2.7f;
        float n3 = n1 * n2;
        Console.WriteLine($"{n1} * {n2} = {n3}");

        //4.to convert feet to meter
        float feet = 5.7f;
        const float rate = 0.3048f;
        float metter = rate * feet;
        Console.WriteLine($"{feet} feet = {metter} metter.");


        //5.to convert Celsius to Fahrenheit and vice versa
        double ce = 27;
        double fa = ce * 1.8 + 32;
        Console.WriteLine($"{ce}℃ = {fa}F");



        //6.to find the Size of data types
        Console.WriteLine($"Size of double data type is {sizeof(double)}");
        Console.WriteLine($"Size of int data type is {sizeof(int)}");


        //7.to Print ASCII Value(tip: read character, print number of this char)
        Console.Write("Enter a character:");
        int z = Console.Read();
        Console.WriteLine($"ASCII code of {(char)z} is {z}");


        //8.to Calculate Area of Circle
        double r = 312;
        double ac = r * 3.14;
        Console.WriteLine($"area of circle is {ac}");


        //9.to Calculate Area of Square
        double canh = 312;
        double aos = Math.Sqrt(canh);
        Console.WriteLine($"area of square is {aos}");



        //10.to convert days to years, weeks and days
        double d = 2100;
        double y = Math.Floor(d / 365);
        double m = Math.Floor((d - y * 365) / 30);
        double w = Math.Floor((d - y * 365 - m * 30) / 7);
        Console.WriteLine($" {d} = {y} years {m} months {w} weeks");





        Console.ReadKey();
    }
}
