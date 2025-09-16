namespace _06_calculate_rectangle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(area(a, b));
        }

        public static int area(int a, int b)
        {
            return a * b;
        }
    }
}
