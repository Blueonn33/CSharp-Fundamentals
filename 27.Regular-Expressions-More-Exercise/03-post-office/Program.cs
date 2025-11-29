using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split('|', 3);

        string firstPart = parts[0];
        string secondPart = parts[1];
        string thirdPart = parts[2];

        var capPattern = new Regex(@"([#\$%\*&])([A-Z]+)\1");
        var capMatch = capPattern.Match(firstPart);
        if (!capMatch.Success) return;

        string capitals = capMatch.Groups[2].Value;

        var secondPattern = new Regex(@"(\d{2,3}):(\d{2})");
        var matches = secondPattern.Matches(secondPart);

        var needed = new Dictionary<char, int>();

        foreach (Match m in matches)
        {
            int ascii = int.Parse(m.Groups[1].Value);
            int len = int.Parse(m.Groups[2].Value);
            char letter = (char)ascii;

            if (capitals.Contains(letter) && !needed.ContainsKey(letter))
                needed[letter] = len + 1;
        }

        string[] words = thirdPart.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (char c in capitals)
        {
            if (!needed.ContainsKey(c)) continue;

            int targetLen = needed[c];

            foreach (string w in words)
            {
                if (w.Length == targetLen && w[0] == c)
                {
                    Console.WriteLine(w);
                    break;
                }
            }
        }
    }
}
