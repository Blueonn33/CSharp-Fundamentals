namespace _04_refactoring_prime_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 2; i <= range; i++)
            {
                string isPrime = "true";
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime = "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime);
            }
        }
    }
}
