using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CSLT_26C1INF50900501_B2._501_C2.buoi7
{

    //orders them by implementing the bubble sort algorithm.

    //Create a program with following functions
    //Create an integer matrix N x M(N, M was prompted from user) randomly.
    //Print the matrix.
    //Print the ith row/column. (i was prompted from user)
    //Find the max value of the matrix.
    //Find the min value of ith row / col of the matrix.
    //Transpose the matrix.
    //Print the main / secondary diagonal values of the matrix.(square maxtrix)
    internal class baitapsort
    {
        static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            { 
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j+1] = temp;
                        
                    }
                }
            }
        }

        static bool Linear(string s, string w)
        {
            string[] words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0;i < words.Length;i++)
            {
                if (words[i].Equals(w, StringComparison.OrdinalIgnoreCase))
                {
                    return true;    
                }
            }
            return false;
        }

        public static void Mainsort(string[] args)
        {
            //1
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter {i} integer : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(arr);
            Console.WriteLine("array after sorted :");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            //2 
            Console.WriteLine("Enter a sentence");
            string sen = Console.ReadLine()  ??  "";
            Console.WriteLine("Enter the word to search ");
            string word = Console.ReadLine() ?? "";
            bool check = Linear(sen, word);
            if (check)
            {
                Console.WriteLine($"{word} is in the sentence ");
            }
            else
            {
                Console.WriteLine($"{word} is not in the sentence ");
            }


            }
    }
}