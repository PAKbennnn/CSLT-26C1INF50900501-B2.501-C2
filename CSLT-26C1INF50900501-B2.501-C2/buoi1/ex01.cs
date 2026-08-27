using System;
using System.Resources;
 namespace CSLT_26C1INF50900501_B2._501_C2.buoi1

{
    internal class Program
    {
        static void Main2(string[] args)
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