using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_moba_challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary<string, int>>();
            string input;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] parts = input.Split(" -> ");
                    string player = parts[0];
                    string position = parts[1];
                    int skill = int.Parse(parts[2]);

                    if (!players.ContainsKey(player))
                        players[player] = new Dictionary<string, int>();

                    if (!players[player].ContainsKey(position))
                        players[player][position] = skill;
                    else if (players[player][position] < skill)
                        players[player][position] = skill;
                }
                else if (input.Contains("vs"))
                {
                    string[] parts = input.Split(" vs ");
                    string first = parts[0];
                    string second = parts[1];

                    if (players.ContainsKey(first) && players.ContainsKey(second))
                    {
                        var common = players[first].Keys.Intersect(players[second].Keys);
                        if (common.Any())
                        {
                            int firstTotal = players[first].Values.Sum();
                            int secondTotal = players[second].Values.Sum();

                            if (firstTotal > secondTotal)
                                players.Remove(second);
                            else if (secondTotal > firstTotal)
                                players.Remove(first);
                        }
                    }
                }
            }

            foreach (var player in players
                .OrderByDescending(p => p.Value.Values.Sum())
                .ThenBy(p => p.Key))
            {
                int total = player.Value.Values.Sum();
                Console.WriteLine($"{player.Key}: {total} skill");

                foreach (var pos in player.Value
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {pos.Key} <::> {pos.Value}");
                }
            }
        }
    }
}
