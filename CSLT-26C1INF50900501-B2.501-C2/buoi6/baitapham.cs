using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace CSLT_26C1INF50900501_B2._501_C2.buoi6
{
    internal class baitapham
    {
        static  int tinhtong(int a, int b)
        {
            return (a + b);

        }
        static bool chanle(int c)
        {
                     return c % 2 == 0;
        }
        static int max(int d, int e, int f)
        {
            return Math.Max(Math.Max(d, e), f);
        }
        static long factorial(int g)
        {
            if (g == 1 || g == 0)
            {
                return 1;
            }
            else
            {
                long result = 1;
                for (int i = 2; i <= g; i++)
                {
                    result *= i;
                }
                return result;
            }

         }

        static string daonguocchuoi(string chuoi) 
        {
            if (string.IsNullOrEmpty(chuoi))
            {
                return chuoi;
            }
            else
            {
                char[] mang = chuoi.ToCharArray();
                Array.Reverse(mang);
                return new string(mang);
            }
        }
        static bool prime(int h)
        {
            if (h < 2)
                return false;

            for (int i = 2; i <= h / 2; i++)
            {
                if (h % i == 0)
                    return false;
            }
            return true;
        }

        static void fibonacci(int k)
        {
            int a = 0; 
            int b = 1;
            for (int i = 0; i < k; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
        }

        static int demnguyenam(string s)
        {
            int count = 0;
            string lower = s.ToLower();
            foreach (char c in lower)
            {
                if (c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'u')
                {
                    count++;
                }
            }
            return count;

        }

        static double luythua(double x, int y)
        {
            double luythua = 1;
            for(int i = 0;i < y;i++)
            {
                luythua = luythua * x ;
            }
            return luythua;
        }
        static double TinhTrungBinh(int[] arr)
        {
          int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return (double)sum / arr.Length;

        }
        static bool palindrome(string s) 
        {
            string clean = s.ToLower();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (clean[left] != clean[right])
                {
                    return false;
                    left++;
                    right--;
                }
                
            }
            return true;

        }
        static double CelsiusToFahrenheit(double c)
        {
            return c * 9.0 / 5.0 + 32;
        }
        static int TimMin(int[] arr)
        {
            int min = 0;
            foreach(int i in arr)
            {
                if (i < min)
                  min = i;           
            }
            return min;
        }
        static int TongCacChuSo(int p)
        {
            int sum = 0;
            while (p >0)
            {
                sum += p % 10;
                p /= 10;
            }
            return sum;
        }
        static void SapXepMang(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }


        public static void Main(string[] args)
        {
            // bai 1
            Console.WriteLine("Enter a : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int tong = tinhtong(n1, n2);
            Console.WriteLine($"a + b = {tong}");
            // bai 2
            Console.WriteLine("nhap so can kiem tra");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (chanle(n3))
                Console.WriteLine("day la 1 so chan");
            else
                Console.WriteLine("day la 1 so le");
            // bai 3
            Console.WriteLine("Enter a : ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            int n5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a : ");
            int n6 = Convert.ToInt32(Console.ReadLine());
            int lonnhat = max(n4 , n5 , n6 );
            Console.WriteLine($"so lon nhat la {lonnhat}");
            //bai 4
            Console.Write("enter a integer ");
            int n7 = Convert.ToInt32(Console.ReadLine());
            if (n7 < 0)
            {
                Console.WriteLine("Number must be a integer, try again!!! ");
            }
            else
                Console.Write($"your factorial is ");
            Console.WriteLine(factorial(n7));
            //bai 5
            Console.WriteLine("nhap chuoi can dao nguoc :");
            string text = Console.ReadLine();

            string result = daonguocchuoi(text);
            Console.Write("chuoi sau khi dao la :");
            Console.WriteLine(result);
            //bai 6
            Console.WriteLine("enter a integer : ");
            int n8 = Convert.ToInt32(Console.ReadLine());
            if (prime(n8))
                Console.WriteLine($"{n8} is a prime number");
            else
                Console.WriteLine($"{n8} is not a prime number");
            //bai 7
            Console.WriteLine("enter n:");
            int n9 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"fibonacci of {n9} is: ");
            fibonacci(n9);
            Console.WriteLine();

            //bai 8
            Console.WriteLine("nhap chuoi can dem:");
            string chui = Console.ReadLine();
            int cout = demnguyenam(chui);
            Console.Write($"so nguyen am la :{cout}");
            
            Console.WriteLine();
            //bai 9 
            Console.WriteLine("nhap co so  : ");
            double n10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter so mu : ");
            int n11 = Convert.ToInt32(Console.ReadLine());
            double lt = luythua(n10, n9);
            Console.WriteLine(lt);
            //bai 10
            Console.WriteLine("nhap so luong phan tu");
            int n12 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n12];
            for (int i = 0; i < n12; i++)
            {
                Console.WriteLine($"nhap phan tu thu {i+1} cua day");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            double avg = TinhTrungBinh(arr);           
            Console.WriteLine($"trung binh cua day la {avg}");
            //bai 11
            Console.WriteLine("nhap chuoi can kiem tra:");
            string choi = Console.ReadLine() ?? "";
            bool result1 = palindrome(choi);
            if (result1)
            {
                Console.WriteLine("la 1 chuoi doi xung");
            }
            else { Console.WriteLine("la 1 khong chuoi doi xung"); }
            //bai 12
            Console.WriteLine("Nhập độ C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double dotay = CelsiusToFahrenheit(c);
            Console.WriteLine($"Độ F: {dotay}");
            //bai 13
            Console.WriteLine("nhap so luong phan tu");
            int n13 = Convert.ToInt32(Console.ReadLine());
            int[] arry = new int[n13];
            for (int i = 0; i < n13; i++)
            {
                Console.WriteLine($"nhap phan tu thu {i + 1} cua day");
                arry[i] = Convert.ToInt32(Console.ReadLine());
            }
            double min13 = TimMin(arry);
            Console.WriteLine($"Min cua day la {arry}");
            //bai 14
            Console.WriteLine("Nhập số nguyên n: ");
            int n14 = Convert.ToInt32(Console.ReadLine());
            int re = TongCacChuSo(n14);
            Console.WriteLine($"Tổng các chữ số: {re}");
            //bai 15
            Console.WriteLine("nhap so luong phan tu");
            int n15 = Convert.ToInt32(Console.ReadLine());
            int[] ary = new int[n15];
            for (int i = 0; i < n15; i++)
            {
                Console.WriteLine($"nhap phan tu thu {i + 1} cua day");
                arry[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Mảng sau khi sắp xếp: ");
            foreach (int n in ary)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            //bai 16




            Console.ReadKey();
        }
    }
}
