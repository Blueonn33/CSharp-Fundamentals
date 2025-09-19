namespace _08_factorial_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal first = decimal.Parse(Console.ReadLine());
            decimal second = decimal.Parse(Console.ReadLine());

            decimal result = factorial(first) / factorial(second);
            Console.WriteLine($"{result:F2}");
        }

        public static decimal factorial(decimal number)
        {
            decimal result = 1;

            while(number > 0)
            {
                result *= number;
                number--;
            }

            return result;
        }
    }
}
