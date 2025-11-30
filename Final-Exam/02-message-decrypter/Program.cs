using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string pattern = @"^(?<tagSymb>[$%])(?<tag>[A-Z][a-z]{2,})\k<tagSymb>: (?:\[(?<num>\d+)\]\|){3}$";

        for (int i = 0; i < count; i++)
        {
            string command = Console.ReadLine();
            Match match = Regex.Match(command, pattern);

            if (match.Success)
            {
                string tag = match.Groups["tag"].Value;

                var numbers = match.Groups["num"].Captures
                    .Cast<Capture>()
                    .Select(c => c.Value)
                    .ToArray();

                StringBuilder decryptedMessage = new StringBuilder();

                foreach (string num in numbers)
                {
                    int asciiValue = int.Parse(num);
                    decryptedMessage.Append((char)asciiValue);
                }

                Console.WriteLine($"{tag}: {decryptedMessage}");
            }
            else
            {
                Console.WriteLine("Valid message not found!");
            }
        }
    }
}