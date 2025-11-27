using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_teamwork_projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string command = Console.ReadLine();
                string[] getTeamInfo = command.Split("-");

                string creator = getTeamInfo[0];
                string teamName = getTeamInfo[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team()
                    {
                        Creator = creator,
                        Name = teamName
                    };
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string usersCommand = Console.ReadLine();
            while (usersCommand != "end of assignment")
            {
                string[] getUserInfo = usersCommand.Split("->");
                string userName = getUserInfo[0];
                string teamName = getUserInfo[1];

                Team team = teams.FirstOrDefault(t => t.Name == teamName);

                if (team == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(t => t.Users.Any(u => u.Name == userName)) || teams.Any(t => t.Creator == userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                }
                else
                {
                    team.Users.Add(new User() { Name = userName });
                }

                usersCommand = Console.ReadLine();
            }

            foreach (Team team in teams
                .Where(t => t.Users.Count > 0)
                .OrderByDescending(t => t.Users.Count)
                .ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (User user in team.Users.OrderBy(u => u.Name))
                {
                    Console.WriteLine($"-- {user.Name}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in teams.Where(t => t.Users.Count == 0).OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }

        public Team()
        {
            Users = new List<User>();
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}