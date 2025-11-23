using System;
using System.Text.RegularExpressions;

string input = Console.ReadLine() ?? "";
string[] tickets = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

string winning = "@#$^";

foreach (var raw in tickets)
{
    string ticket = raw.Trim();

    if (ticket.Length != 20)
    {
        Console.WriteLine("invalid ticket");
        continue;
    }

    string left = ticket.Substring(0, 10);
    string right = ticket.Substring(10, 10);

    int bestLen = 0;
    char bestSym = '\0';

    foreach (char sym in winning)
    {
        int leftLen = LongestRun(left, sym);
        int rightLen = LongestRun(right, sym);

        int matchLen = Math.Min(leftLen, rightLen);

        if (matchLen > bestLen)
        {
            bestLen = matchLen;
            bestSym = sym;
        }
    }

    if (bestLen >= 6 && bestLen <= 9)
    {
        Console.WriteLine($"ticket \"{ticket}\" - {bestLen}{bestSym}");
    }
    else if (bestLen == 10)
    {
        Console.WriteLine($"ticket \"{ticket}\" - {bestLen}{bestSym} Jackpot!");
    }
    else
    {
        Console.WriteLine($"ticket \"{ticket}\" - no match");
    }
}

static int LongestRun(string s, char sym)
{
    int maxRun = 0, cur = 0;
    foreach (char c in s)
    {
        if (c == sym)
        {
            cur++;
            if (cur > maxRun) maxRun = cur;
        }
        else
        {
            cur = 0;
        }
    }
    return maxRun;
}