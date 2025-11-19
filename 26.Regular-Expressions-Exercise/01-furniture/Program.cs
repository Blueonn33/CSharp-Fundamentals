using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @">>(?<product>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
        string input;
        List<string> products = new List<string>();
        double totalPrice = 0.0;

        while ((input = Console.ReadLine()) != "Purchase")
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                string product = match.Groups["product"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                products.Add(product);
                totalPrice += price * quantity;
            }
        }

        Console.WriteLine("Bought furniture:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine($"Total money spent: {totalPrice:F2}");
    }
}