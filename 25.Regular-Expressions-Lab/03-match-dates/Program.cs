using System.Text.RegularExpressions;

string text = Console.ReadLine();
string pattern = @"\b(?<date>[\d]{2})(?<separator>[\-\/\.])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[\d]{4})\b";

MatchCollection matches = Regex.Matches(text, pattern);

foreach (Match match in matches)
{
    var day = match.Groups["date"].Value;
    var month = match.Groups["month"].Value;
    var year = match.Groups["year"].Value;

    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}
