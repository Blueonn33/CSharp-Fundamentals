namespace _09_sum_of_odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += i * 2 + 1;
                Console.WriteLine(i * 2 + 1);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
