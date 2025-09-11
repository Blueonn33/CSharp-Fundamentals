using System.Diagnostics.CodeAnalysis;

namespace _02_from_left_to_right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] numbers = input.Split();

                long firstNumber = long.Parse(numbers[0]);
                long secondNumber = long.Parse(numbers[1]);
                int sum = 0;

                if (firstNumber > secondNumber)
                {
                    firstNumber = Math.Abs(firstNumber);
                    while (firstNumber > 0)
                    {
                        int digit = (int)(firstNumber % 10);
                        firstNumber /= 10;
                        sum += digit;
                    }
                }
                else
                {
                    secondNumber = Math.Abs(secondNumber);
                    while (secondNumber > 0)
                    {
                        int digit = (int)(secondNumber % 10);
                        secondNumber /= 10;
                        sum += digit;
                    }
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
