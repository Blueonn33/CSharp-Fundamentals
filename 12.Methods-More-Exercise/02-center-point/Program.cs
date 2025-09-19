namespace _02_center_point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            findClosestPoint(x1, y1, x2, y2);
        }

        public static void findClosestPoint(int x1, int y1, int x2, int y2)
        {
            int distance1 = x1 * x1 + y1 * y1;
            int distance2 = x2 * x2 + y2 * y2;

            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
