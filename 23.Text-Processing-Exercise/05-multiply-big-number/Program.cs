using System.Numerics;

namespace _05_multiply_big_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigInt = BigInteger.Parse(Console.ReadLine());
            BigInteger multiplier = BigInteger.Parse(Console.ReadLine());

            BigInteger result = bigInt * multiplier;
            Console.WriteLine(result);
        }
    }
}
