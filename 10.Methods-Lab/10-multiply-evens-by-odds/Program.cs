using System.Runtime.Intrinsics.X86;

namespace _10_multiply_evens_by_odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            getMultipleOfEvenAndOdds(number);
        }

        public static void getMultipleOfEvenAndOdds(int number)
        {
            Console.WriteLine(getSumOfEvenDigits(number) * getSumOfOddDigits(number));
        }

        public static int getSumOfEvenDigits(int number)
        {
            int total = 0;

            while(number > 0)
            {
                int digit = number % 10;

                if(digit % 2 == 0)
                {
                    total += digit;
                }

                number /= 10;
            }

            return total;
        }

        public static int getSumOfOddDigits(int number)
        {
            int total = 0;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    total += digit;
                }

                number /= 10;
            }

            return total;
        }
    }
}
