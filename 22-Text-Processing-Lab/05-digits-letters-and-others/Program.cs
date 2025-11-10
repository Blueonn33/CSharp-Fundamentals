namespace _05_digits_letters_and_others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> others = new List<char>();

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Add(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Add(symbol);
                }
                else
                {
                    others.Add(symbol);
                }
            }

            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", others));
        }
    }
}
