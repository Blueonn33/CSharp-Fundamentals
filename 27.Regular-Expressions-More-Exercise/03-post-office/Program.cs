using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split('|');
        string first = parts[0];
        string second = parts[1];
        string third = parts[2];

        var caps = new HashSet<char>();
        var m1 = Regex.Matches(first, @"(?<symb>[#\$%\*&])(?<letters>[A-Z]+)\k<symb>");
        foreach (Match m in m1)
        {
            foreach (char c in m.Groups["letters"].Value)
                caps.Add(c);
        }

        var pairs = new List<(char Letter, int Length)>();
        var seen = new HashSet<char>();
        var m2 = Regex.Matches(second, @"(?<code>\d{2}):(?<len>\d{2})");
        foreach (Match m in m2)
        {
            int code = int.Parse(m.Groups["code"].Value);
            int len = int.Parse(m.Groups["len"].Value);
            char letter = (char)code;

            if (caps.Contains(letter) && !seen.Contains(letter))
            {
                pairs.Add((letter, len + 1));
                seen.Add(letter);
            }
        }

        var tokens = third.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var results = new List<string>();

        foreach (var (Letter, Length) in pairs)
        {
            string found = tokens.FirstOrDefault(t => t[0] == Letter && t.Length == Length);
            if (found != null)
                results.Add(found);
        }

        Console.WriteLine(string.Join(Environment.NewLine, results));
    }
}