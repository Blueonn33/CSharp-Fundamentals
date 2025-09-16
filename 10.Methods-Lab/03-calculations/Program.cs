using System.Collections.Generic;

namespace _03_calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            calculate(action, number, secondNumber);
        }

        public static void calculate(string action, int a, int b)
        {
            int result = 0;
            switch (action)
            {
                case "add":
                    result = a + b;
                    break;
                case "multiply":
                    result = a * b;
                    break;
                case "subtract":
                    result = a - b;
                    break;
                case "divide":
                    result = a / b;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
