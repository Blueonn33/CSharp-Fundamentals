namespace _01_smallest_of_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            findSmallest(a, b, c);
        }

        public static void findSmallest(int a, int b, int c)
        {
            int first = Math.Min(a, b);
            int result = Math.Min(c, first);
            Console.WriteLine(result);
        }
    }
}
