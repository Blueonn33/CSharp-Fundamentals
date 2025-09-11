using System.Collections.Generic;

namespace _01_integer_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            double result = ((first + second) / third) * fourth;
            Console.WriteLine(result);
        }
    }
}
