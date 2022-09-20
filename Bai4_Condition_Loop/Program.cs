using System;

namespace Bai4_Condition_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void ptbac2()
        {
            Console.WriteLine("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                // PT co dang: bx + c = 0
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("PT co vo so nghiem");
                    } else
                    {
                        Console.WriteLine("PT vo nghiem");
                    }
                } else
                {
                    double x = (double)-b / (2 * a);
                    // ...
                }
            } else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("PT vo nghiem");
                } else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    //
                } else
                {
                    double sqrtDelta = Math.Sqrt(delta);

                    double x1 = (-b + sqrtDelta) / (2 * a);
                    double x2 = (-b - sqrtDelta) / (2 * a);
                }
            }
        }

        static void tinhThue()
        {
            Console.WriteLine("Nhap tong thu nhap trong thang (nghin dong): ");
            String s = Console.ReadLine();
            int luong = int.Parse(s);
            double thue = 0;
            if (luong < 9000)
            {
                thue = 0;
            } else if (luong < 15000)
            {
                thue = ((double)luong) * 0.1;
            } else if (luong < 30000)
            {
                thue = (double)luong * 0.15;
            } else
            {
                thue = (double)luong * 0.2;
            }
        }
    }
}
