using System;
using System.Text.RegularExpressions;

string input = Console.ReadLine();

string pattern =
    @"(?<=^|\s)" +
    @"(?<user>[A-Za-z0-9]+(?:[._-][A-Za-z0-9]+)*)" +
    @"@" +
    @"(?<host>[A-Za-z]+(?:-[A-Za-z]+)*(?:\.[A-Za-z]+(?:-[A-Za-z]+)*)+)" +
    @"(?=$|\s|[.,!?])";

MatchCollection matches = Regex.Matches(input, pattern);

foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}