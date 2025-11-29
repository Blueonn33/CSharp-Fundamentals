using System;

class Program
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        double line1Length = CalcDistance(x1, y1, x2, y2);
        double line2Length = CalcDistance(x3, y3, x4, y4);

        if (line1Length >= line2Length)
        {
            PrintLine(x1, y1, x2, y2);
        }
        else
        {
            PrintLine(x3, y3, x4, y4);
        }
    }

    static void PrintLine(double x1, double y1, double x2, double y2)
    {
        double firstDistance = CalcDistance(x1, y1, 0, 0);
        double secondDistance = CalcDistance(x2, y2, 0, 0);

        if (firstDistance <= secondDistance)
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }

    static double CalcDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    }
}