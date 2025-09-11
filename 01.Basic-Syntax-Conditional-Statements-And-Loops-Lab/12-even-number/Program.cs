namespace _12_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number % 2 != 0)
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Please write an even number.");
            }

            Console.WriteLine("The number is: " + Math.Abs(number));
        }
    }
}
