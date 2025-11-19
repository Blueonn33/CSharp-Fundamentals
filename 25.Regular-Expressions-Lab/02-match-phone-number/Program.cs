using System;
using System.Text.RegularExpressions;

namespace _02_match_phone_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\+359(?<separator>[- ])2\k<separator>[\d]{3}\k<separator>[\d]{4}\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            Console.Write(string.Join(", ", matches));
        }
    }
}
