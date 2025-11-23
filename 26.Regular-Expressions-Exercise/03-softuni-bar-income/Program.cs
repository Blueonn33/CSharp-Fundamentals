using System;
using System.Globalization;
using System.Text.RegularExpressions;

string line;
double total = 0;

string pattern = @"%(?<name>[A-Z][a-z]+)%[^\|$%\.]*<(?<product>\w+)>[^\|$%\.]*\|(?<count>\d+)\|[^\|$%\.]*?(?<price>\d+(?:\.\d+)?)\$";

while ((line = Console.ReadLine()) != "end of shift")
{
    Match m = Regex.Match(line, pattern);
    if (!m.Success) continue;

    string name = m.Groups["name"].Value;
    string product = m.Groups["product"].Value;
    int count = int.Parse(m.Groups["count"].Value);
    double price = double.Parse(m.Groups["price"].Value, CultureInfo.InvariantCulture);

    double totalPrice = count * price;
    total += totalPrice;

    Console.WriteLine($"{name}: {product} - {totalPrice:F2}");
}

Console.WriteLine($"Total income: {total:F2}");