namespace _01_sign_of_integer_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            checkNumber(number);
        }

        public static void checkNumber(int number)
        {
            string result = number > 0 ? "positive" : number < 0 ? "negative" : "zero";
            Console.WriteLine($"The number {number} is {result}.");
        }
    }
}
