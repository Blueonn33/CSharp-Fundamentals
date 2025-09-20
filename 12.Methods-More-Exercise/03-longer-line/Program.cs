namespace _03_longer_line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            int x3 = 0, y3 = 0, x4 = 0, y4 = 0;

            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            x4 = int.Parse(Console.ReadLine());
            y4 = int.Parse(Console.ReadLine());

            double firstLine = findLongerLine(x1, y1, x2, y2);
            double secondLine = findLongerLine(x3, y3, x4, y4);

            if (firstLine > secondLine)
            {
                findClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                findClosestPoint(x3, y3, x4, y4);
            }
        }

        public static void findClosestPoint(int x1, int y1, int x2, int y2)
        {
            int distance1 = x1 * x1 + y1 * y1;
            int distance2 = x2 * x2 + y2 * y2;

            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        public static double findLongerLine(int x1, int y1, int x2, int y2)
        {
            double line = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return line;
        }
    }
}
