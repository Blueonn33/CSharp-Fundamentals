using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string line;
        string pattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*!(?<behavior>[GN])!";

        List<string> goodChildren = new List<string>();

        while ((line = Console.ReadLine()) != "end")
        {
            string decrypted = string.Concat(line.Select(ch => (char)(ch - key)));

            Match match = Regex.Match(decrypted, pattern);
            if (match.Success && match.Groups["behavior"].Value == "G")
            {
                goodChildren.Add(match.Groups["name"].Value);
            }
        }

        foreach (string child in goodChildren)
        {
            Console.WriteLine(child);
        }
    }
}