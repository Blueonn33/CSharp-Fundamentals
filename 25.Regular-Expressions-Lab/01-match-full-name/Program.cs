using System.Text.RegularExpressions;

namespace _01_match_full_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (var match in matches)
            {
                Console.Write(match + " ");
            }
        }
    }
}
