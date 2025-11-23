using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

string? names = Console.ReadLine();
string[] participants = string.IsNullOrWhiteSpace(names)
    ? Array.Empty<string>()
    : names.Split(", ", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> racers = new Dictionary<string, int>();

foreach (string participant in participants)
{
    if (!racers.ContainsKey(participant))
        racers.Add(participant, 0);
}

while (true)
{
    string? command = Console.ReadLine();
    if (command == null || command == "end of race")
        break;

    // extract only letters for the name
    string name = string.Concat(Regex.Matches(command, "[A-Za-z]").Select(m => m.Value));

    // extract only digits and sum them
    int km = Regex.Matches(command, "[0-9]").Select(m => int.Parse(m.Value)).Sum();

    if (racers.ContainsKey(name))
    {
        racers[name] += km;
    }
}

var top3 = racers.OrderByDescending(x => x.Value).Take(3).ToList();
if (top3.Count > 0) Console.WriteLine($"1st place: {top3[0].Key}");
if (top3.Count > 1) Console.WriteLine($"2nd place: {top3[1].Key}");
if (top3.Count > 2) Console.WriteLine($"3rd place: {top3[2].Key}");