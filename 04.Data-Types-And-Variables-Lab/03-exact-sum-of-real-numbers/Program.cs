namespace _03_exact_sum_of_real_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal total = 0;
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                total += number;
            }

            Console.WriteLine(total);
        }
    }
}
