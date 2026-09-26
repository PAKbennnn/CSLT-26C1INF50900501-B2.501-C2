using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_B2._501_C2.buoi7
{
    internal class baitapmatrix
    {
        static void randommatrix(int[,] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                }
            }
        }
        static void printarry(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($" {a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static int maxValue(int[,] a)
        {
            int max = a[0, 0];
            foreach (int item in a)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        static void PrintColumn(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, colIndex] + " ");
            }
            Console.WriteLine();
        }     
        static int maxrow(int[,] a, int row)
        {
            int max = a[row, 0];
            for (int j = 1; j < a.GetLength(1); j++)
            {
                if (a[row, j] > max)
                    max = a[row, j];
            }
            return max;
        }
        static void PrintMainDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();
        }
        static void PrintSecondaryDiagonal(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, n - 1 - i] + " ");
            }
            Console.WriteLine();
        }
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows]; // kích thước bị đảo ngược

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("enter N :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter M :");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr  = new int[n, m];
            randommatrix(arr);
            printarry(arr);


            int max = maxValue(arr);
            Console.WriteLine($"Max value of array is {max}");


            Console.WriteLine($" dòng cần tìm giá trị nhỏ nhất là :");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"min of {row} {maxrow(arr, row)}");
           

            Console.WriteLine("Nhập chỉ số cột cần in : ");
            int colIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Cột {colIndex}: ");
            PrintColumn(arr, colIndex);
            Console.WriteLine();


            Console.WriteLine("Ma trận chuyển vị :");
            int[,] transposed = TransposeMatrix(arr);
            printarry(transposed);

            if (n == m)
            {
                Console.WriteLine();
                Console.Write("Đường chéo chính: ");
                PrintMainDiagonal(arr);
                Console.Write("Đường chéo phụ: ");
                PrintSecondaryDiagonal(arr);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Ma trận không vuông, không thể in đường chéo.");
            }



            Console.ReadKey();  
        }
        
    }
}
