using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPasswords = new();
            Dictionary<string, Dictionary<string, int>> userContests = new();

            string input;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] data = input.Split(':');
                string contest = data[0];
                string password = data[1];
                contestPasswords[contest] = password;
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] data = input.Split("=>");
                string contest = data[0];
                string password = data[1];
                string username = data[2];
                int points = int.Parse(data[3]);

                if (contestPasswords.ContainsKey(contest) &&
                    contestPasswords[contest] == password)
                {
                    if (!userContests.ContainsKey(username))
                        userContests[username] = new Dictionary<string, int>();

                    if (!userContests[username].ContainsKey(contest))
                        userContests[username][contest] = points;
                    else if (userContests[username][contest] < points)
                        userContests[username][contest] = points;
                }
            }

            string bestUser = userContests
                .OrderByDescending(u => u.Value.Values.Sum())
                .First().Key;

            int bestPoints = userContests[bestUser].Values.Sum();

            Console.WriteLine($"Best candidate is {bestUser} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in userContests.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var contest in user.Value
                    .OrderByDescending(c => c.Value)
                    .ThenBy(c => c.Key))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
