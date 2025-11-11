namespace _02_ascii_sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int sum = 0;

            foreach (char character in text)
            {
                if (character > firstChar && character < secondChar)
                {
                    sum += character;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
