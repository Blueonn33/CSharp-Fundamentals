namespace _08_letters_change_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            Dictionary<char, int> alphabet = new();

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                alphabet[letter] = letter - 'A' + 1;
            }

            foreach (string part in parts)
            {
                char firstLetter = part[0];
                char lastLetter = part[part.Length - 1];

                double number = double.Parse(part.Substring(1, part.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number /= alphabet[firstLetter];
                }
                else
                {
                    number *= alphabet[char.ToUpper(firstLetter)];
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= alphabet[lastLetter];
                }
                else
                {
                    number += alphabet[char.ToUpper(lastLetter)];
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
