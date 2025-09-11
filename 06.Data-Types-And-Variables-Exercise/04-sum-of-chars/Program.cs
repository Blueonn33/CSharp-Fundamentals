namespace _04_sum_of_chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                char symb = char.Parse(Console.ReadLine());
                sum += (int)symb;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
