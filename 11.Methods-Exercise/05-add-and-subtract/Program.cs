using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace _05_add_and_subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(addSubtract(first, second, third));
        }

        public static int addSubtract(int first, int second, int third)
        {
            return (first + second) - third;
        }
    }
}
