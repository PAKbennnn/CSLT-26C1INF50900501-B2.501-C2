
using System;
using System.Collections.Generic;
using System.Text;
namespace CSLT_26C1INF50900501_B2._501_C2.buoi4
{
    internal class b4ex1
    {
        static void bai_401()
        {

            // phuong trinh bac 2
            Console.WriteLine("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Trường hợp a = 0 
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình vô số nghiệm.");
                    else
                        Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phương trình bậc 1, có nghiệm duy nhất x = {x}");
                }
                return;
            }

            // Trường hợp a khác 0 
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm ");
            }
        }
            
        static void bai_402()
        {
            Console.WriteLine("Nhập một số nguyên: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine($"{n} là số chẵn.");
            else
                Console.WriteLine($"{n} là số lẻ.");

        }

        static void bai_403()
        {
            Console.WriteLine("Nhập số thứ nhất: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số thứ ba: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine($"Số lớn nhất là: {max}");
        }

        static void bai_404()
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

        static void bai_405()
        {
            Console.WriteLine("Nhập giá trị tọa độ X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập giá trị tọa độ Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Điểm ({x},{y}) nằm ở góc phần tư thứ Nhất ");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Điểm ({x},{y}) nằm ở góc phần tư thứ Hai ");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"Điểm ({x},{y}) nằm ở góc phần tư thứ Ba ");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Điểm ({x},{y}) nằm ở góc phần tư thứ Tư ");
            }
            else
            {
                Console.WriteLine($"Điểm ({x},{y}) nằm tại gốc tọa độ hoặc trên 1 trong 2 trục.");
            }
        }

        private static void Main0(string[] args)
        {
            bai_401();
            bai_402();
            bai_403();
            bai_404();
            bai_405();

        }
        }
    }
