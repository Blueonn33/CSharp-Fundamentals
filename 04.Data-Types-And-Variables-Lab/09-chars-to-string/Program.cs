namespace _09_chars_to_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string result = string.Concat(first, second, third);
            Console.WriteLine(result);
        }
    }
}
