using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSLT_26C1INF50900501_B2._501_C2.buoi6
{
  
    internal class ex1
    {
        static long maxing(long n1, long n2, long n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }
        static bool prime(int n4)
        {
            if (n4 < 2) 
                return false;

            for (int i = 2; i <= n4 /2; i++)
            {
                if (n4 % i == 0)
                    return false;
            }
            return true;
        }  
        static void underprime( int n5)
        {
            for(int i = 2;  i <= n5 /2;i++)
            {
                if(prime(i))
                    Console.Write($"{i}, ");
            }

        }
        static long factorial(int n6 )
        {
            if( n6 ==1 || n6 == 0 )
            {
                return 1;
            }
            else
            {
                long result = 1;
                for(int i = 2;  i <= n6 ; i++)
                {
                    result *= i;
                }
                return result;

            }
        }
        static void stprime(int n)
        {
            int dem = 0;
            int so = 2;
            while (dem < n)
            {
                if (prime(so))
                {
                    Console.Write($"{so}, ");
                    dem++;
                }
                so++;
            }
        }
        static bool perfect(int n7)
        {
            int sum = 0;
            for (int i = 1; i == Math.Sqrt(n7); i++)
            {
                if (n7 % i == 0)
                    sum += i;

            }
            return sum == n7;
           
        }
        static bool pangram(string sen)
        {
            bool[] seen = new bool[26];
            string lower = sen.ToLower();
            foreach (char c in lower)
            { 
                if ( c >= 'a' && c <= 'z' )
                {
                    int index = c - 'a';
                    seen[index] = true;
                }
            }
            foreach (bool found in seen)
            {
                if (!found)
                    return false;
            }
            return true;

        }
     


        public static void Main213(string[] args)
        {
          // bai 1
            Console.Write("enter number 1 ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter number 2 ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter number 3 ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"biggest {maxing(a, b, c)}");

          
            //bai 2
            Console.Write("enter a integer ");
            int f = Convert.ToInt32(Console.ReadLine());
            if ( f < 0 )
            {
                Console.WriteLine("Number must be a integer, try again!!! ");
            }
            else
                Console.Write($"your factorial is ");
                Console.WriteLine(factorial(f));


            // bai 3
            Console.WriteLine("enter a integer : ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (prime(d))
                Console.WriteLine($"{d} is a prime number");
            else
                Console.WriteLine($"{d} is not a prime number");


            // bai 4
            Console.WriteLine("enter number :");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numbers under number {e}");
            underprime(e);
            Console.WriteLine($"the first {e} prime numbers");
            stprime(e);


            //bai 5
            Console.WriteLine("");
            Console.WriteLine("Enter a number to check");
            int g = Convert.ToInt32(Console.ReadLine());
            if (perfect(g))
            {
                Console.WriteLine($" {g} is a perfect number");
            }
            else
            {
                Console.WriteLine($" {g} is not a perfect number");
            }
            
            Console.Write("All perfect number less than 1000:");
            for (int i = 1; i <= 1000; i++)
            {
                perfect(i);
                Console.Write(i + "");
            }
            Console.WriteLine("");


            //bai 6
            Console.WriteLine("enter a sentence");
            string sentence = Console.ReadLine() ?? "";
            if(pangram(sentence))
                Console.WriteLine("This is a pangram ");
            else
                Console.WriteLine("This is not a pangram");






            Console.ReadKey();
        }
    }
}
