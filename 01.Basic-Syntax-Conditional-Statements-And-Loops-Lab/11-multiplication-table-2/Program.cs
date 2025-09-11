namespace _11_multiplication_table_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplicator = int.Parse(Console.ReadLine());
            bool condition = true;

            while (condition)
            {
                Console.WriteLine($"{n} X {multiplicator} = {n * multiplicator}");
                if (multiplicator >= 10)
                {
                    condition = false;
                }
                else
                {
                    multiplicator++;
                }
            }
        }
    }
}
