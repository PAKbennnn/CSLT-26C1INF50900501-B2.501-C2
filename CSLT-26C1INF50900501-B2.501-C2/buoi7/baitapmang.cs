using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSLT_26C1INF50900501_B2._501_C2.buoi7
{
    internal class baitapmang
    {
        // random integer values array
        static void nhap_mang_ngau_nhien(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(10, 500);
            }
        }
        static void in_mang(int[] a)
        {
            foreach (int v in a)
                Console.Write($"{v}, ");
        }

        //1.to calculate the average value of array elements.
        static float avgvalue(int[] a) 
        {
            float sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return (float)sum /a.Length;
        }
        //2.to test if an array contains a specific value.
        static bool searchByValue(int[] a, int x)
        {
            foreach (int v in a)
                if (v == x)
                    return true;
            return false;
        }
        //3.to find the index of an array element.
        static int searchIndex(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        //4.to remove a specific element from an array.
        static int[] removeElement(int[] a,int x)
        {
            int index = searchIndex(a, x);
            if (index == -1)
                return a;
            int [] result = new int[a.Length -1];
            int k = 0;
            for (int i = 0;i < a.Length;i++)
            {
                if (i != index)
                {
                    result[k]=a[i];
                    k++;
                }
            }
            return result;
        }

        //5.to find the maximum and minimum value of an array.
        static void FindMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            foreach (int number in arr)
            {
                if (number > max) max = number;
                if (number < min) min = number;
            }
        }
        //6.to reverse an array of integer values.
        static int[] ReverseArray(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - 1 - i];
            }
            return result;
        }
        //7.to find duplicate values in an array of values.
        static int[] FindDuplicates(int[] arr)
        {
            List<int> duplicates = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !duplicates.Contains(arr[i]))
                    {
                        duplicates.Add(arr[i]);
                    }
                }
            }
            return duplicates.ToArray();
        }
        //8.to remove duplicate elements from an array.
        static int[] RemoveDuplicates(int[] arr)
        {
            List<int> result = new List<int>();
            foreach (int number in arr)
            {
                if (!result.Contains(number))
                {
                    result.Add(number);
                }
            }
            return result.ToArray();
        }

        public static void Mainmang(string[] args)
        {
            int n = 50;
            int[] mang = new int[n];
            nhap_mang_ngau_nhien(mang);
            in_mang(mang);
            //1
            Console.WriteLine();
            float avg = avgvalue(mang);
            Console.WriteLine($"Trung binh gia tri cua mang la {avg}");
            //2
            Console.WriteLine();
            Console.WriteLine("enter value to search");
            int checkval = Convert.ToInt32(Console.ReadLine());
            if (searchByValue(mang, checkval))
            {
                Console.WriteLine("value is exist in array");
            }
            else
            {
                Console.WriteLine("value is not exist in array");
            }
            Console.WriteLine();
            //3
            Console.WriteLine("enter value to find index ");
            int checkindex = Convert.ToInt32(Console.ReadLine());
            int index = searchIndex(mang, checkindex);
            Console.WriteLine($" array has {index}");
            Console.WriteLine();
            //4
            Console.WriteLine("enter value to find index to remove ");
            int checkindextoremove = Convert.ToInt32(Console.ReadLine());
            removeElement(mang, checkindextoremove);
            //5
            FindMaxMin(mang, out int max, out int min);
            Console.WriteLine($"5. Max = {max}, Min = {min}");
            // 6. Đảo ngược mảng
            int[] reversed = ReverseArray(mang);
            Console.Write("6. Mảng sau khi đảo ngược: ");
            in_mang(reversed);
            //7
            int[] duplicates = FindDuplicates(mang);
            Console.Write("7. Các giá trị trùng lặp: ");
            in_mang(duplicates);
            //8
            int[] noDuplicates = RemoveDuplicates(mang);
            Console.Write("8. Mảng sau khi xóa trùng lặp: ");
            in_mang(noDuplicates);

        }
    }
}
