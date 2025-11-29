using System;

namespace _02_center_point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);
        }

        public static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double d1 = x1 * x1 + y1 * y1;
            double d2 = x2 * x2 + y2 * y2;

            if (d1 <= d2)
                Console.WriteLine($"({x1}, {y1})");
            else
                Console.WriteLine($"({x2}, {y2})");
        }
    }
}