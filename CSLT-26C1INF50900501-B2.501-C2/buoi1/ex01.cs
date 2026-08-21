using System;
using System.Resources;
namespace _1stprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Canh goc vuong thu nhat la :");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Canh goc vuong thu hai la :");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("canh huyen la : " + c);

            Console.ReadKey();
        }
    }
}