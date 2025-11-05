using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Dictionary<string, Dictionary<string, int>> contestData = new();

            while (true)
            {
                command = Console.ReadLine();

                if (command == "no more time")
                {
                    break;
                }

                string[] commandData = command.Split(" -> ");

                string username = commandData[0];
                string contest = commandData[1];
                int points = int.Parse(commandData[2]);

                if (!contestData.ContainsKey(contest))
                {
                    // create new contest and add user
                    contestData[contest] = new Dictionary<string, int>();
                    contestData[contest][username] = points;
                }
                else
                {
                    // contest exists -> check if user exists in this contest
                    if (!contestData[contest].ContainsKey(username))
                    {
                        // user not present yet -> add
                        contestData[contest][username] = points;
                    }
                    else
                    {
                        // user already present -> keep the higher score
                        if (points > contestData[contest][username])
                        {
                            contestData[contest][username] = points;
                        }
                    }
                }
            }

            // print each contest and its participants
            foreach (var contest in contestData)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int position = 1;

                foreach (var user in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{position}. {user.Key} <::> {user.Value}");
                    position++;
                }
            }

            // build and print individual standings (aggregate best scores per user across all contests)
            Console.WriteLine("Individual standings:");
            Dictionary<string, int> individualStandings = new();

            foreach (var contest in contestData)
            {
                foreach (var user in contest.Value)
                {
                    // initialize to 0 if user not present, then add this contest's best points
                    if (!individualStandings.ContainsKey(user.Key))
                    {
                        individualStandings[user.Key] = 0;
                    }

                    individualStandings[user.Key] += user.Value;
                }
            }

            int posFinal = 1;
            foreach (var user in individualStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{posFinal}. {user.Key} -> {user.Value}");
                posFinal++;
            }
        }
    }
}
