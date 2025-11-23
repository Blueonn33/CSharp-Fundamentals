using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern = @"(?<word>[^0-9]+)(?<count>\d+)";
MatchCollection matches = Regex.Matches(input, pattern);

StringBuilder sb = new StringBuilder();

foreach (Match match in matches)
{
    string word = match.Groups["word"].Value.ToUpper();
    int count = int.Parse(match.Groups["count"].Value);

    for (int i = 0; i < count; i++)
    {
        sb.Append(word);
    }
}

string result = sb.ToString();
int uniqueSymbols = result.Distinct().Count();

Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
Console.WriteLine(result);