using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_B2._501_C2.buoi5
{
    internal class b5ex1()
    {
        static void bai1b5()
        {
            Console.WriteLine("Nhập cạnh a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập cạnh b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập cạnh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Kiểm tra điều kiện tạo thành tam giác hợp lệ trước
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Đây không phải là 3 cạnh của một tam giác.");
                return;
            }

            if (a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác Đều ");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Đây là tam giác Cân ");
            }
            else
            {
                Console.WriteLine("Đây là tam giác Thường ");
            }
        }
        static void bai2b5()
        {
            int num = 10;
            Double sum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter number {i}");
                double a = Convert.ToDouble(Console.ReadLine());
                sum += a;
            }
            double avg = sum / num;
            Console.WriteLine($"Tổng của 10 số: {sum}");
            Console.WriteLine($"Trung bình của 10 số: {avg}");
        }
        static void bai3b5()
        {
            Console.WriteLine("Enter a :");
            int  a = Convert.ToInt32(Console.ReadLine());

          
                for (int j = 1; j < 10  ; j++)
                {
                    Console.WriteLine($" {a} * {j} = {a * j}");

                }
            
        }
        static void bai4b5()
        {
            Console.WriteLine("Nhập số dòng n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
       
        static void bai6b5()
        {
            Console.WriteLine($"Nhập số hạng n :");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            Console.Write("chuỗi :");
            for (int i = 0;i <= n;i++)
            {
                double term = 1.0 / i;
                sum += term;

                if (i == 1)
                    Console.Write($"1");
                else
                    Console.Write($" + 1/{i}");
            }
            Console.WriteLine();
            Console.WriteLine($"Tổng chuỗi Harmonic đến {n} số hạng là: {sum}");
        }
        static void bai7b5()
        {
            Console.WriteLine("Enter a number to check");
            int  a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i == Math.Sqrt(a) ; i++)
            {
                if (a % i == 0)
                    sum += i;

            }
            if (sum == a)
            {
                Console.WriteLine($"a is a perfect number");
            }
            else
            {
                Console.WriteLine($"a is not a perfect number");
            }

        }
        static void bai8b5()
        {
            Console.Write("nhap so can kiem tra :");
            int a = Convert.ToInt32(Console.ReadLine());
            bool kt = true;
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    kt = false;
                    break;
                }
                if (kt)
                    Console.WriteLine($" {a} la so nguyen to");
                else
                    Console.WriteLine($"{a} khong la so nguyen to");
            }
        }


        private static void Main(string[] args)
        {
            bai1b5();
            bai2b5();
            bai3b5();
            bai4b5();
            bai6b5(); 
            bai7b5();
            bai8b5();
         


            Console.ReadKey();
        }
    }
} 