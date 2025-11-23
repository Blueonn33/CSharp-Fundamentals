using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string[] demonNames = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, (int health, double damage)> demons = new();

foreach (string demonName in demonNames)
{
    // Health: sum of ASCII codes of all chars except digits and + - * / .
    int health = demonName
        .Where(ch => !char.IsDigit(ch) && ch != '+' && ch != '-' && ch != '*' && ch != '/' && ch != '.')
        .Sum(ch => (int)ch);

    // Damage: sum of all numbers (integers or decimals, with optional sign)
    double damage = 0;
    MatchCollection damageMatches = Regex.Matches(demonName, @"-?\d+(\.\d+)?");
    foreach (Match m in damageMatches)
    {
        damage += double.Parse(m.Value, CultureInfo.InvariantCulture);
    }

    // Apply multipliers/dividers
    foreach (char ch in demonName)
    {
        if (ch == '*') damage *= 2;
        else if (ch == '/') damage /= 2;
    }

    demons[demonName] = (health, damage);
}

foreach (var demon in demons.OrderBy(d => d.Key))
{
    Console.WriteLine($"{demon.Key} - {demon.Value.health} health, {demon.Value.damage:F2} damage");
}