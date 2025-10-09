namespace _05_teamwork_projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            List<User> users = new List<User>();
            Team teamObj = new Team();
            //John-PowerPuffsCoders
            for (int i = 0; i < teamsCount; i++)
            {
                string command = Console.ReadLine();
                string[] getTeamInfo = command.Split("-");

                if(teams.Count == 0)
                {
                    teamObj.Creator = getTeamInfo[0];
                    teamObj.Name = getTeamInfo[1];
                    teams.Add(teamObj);
                    Console.WriteLine($"Team {teamObj.Name} has been created by {teamObj.Creator}!");
                }
                else
                {
                    foreach (Team team in teams)
                    {
                        if (team.Name == getTeamInfo[0])
                        {
                            Console.WriteLine($"Team {team.Name} was already created!");
                        }
                        else
                        {

                            teamObj.Creator = getTeamInfo[0];
                            teamObj.Name = getTeamInfo[1];
                            teams.Add(teamObj);
                            Console.WriteLine($"Team {teamObj.Name} has been created by {teamObj.Creator}!");
                        }
                    }
                }

            }

            string usersCommand = Console.ReadLine();

            while (usersCommand != "end of assignment")
            {
                string[] getUserInfo = usersCommand.Split("->");
                
                foreach(Team team in teams)
                {
                    if(team.Name != getUserInfo[1])
                    {
                        Console.WriteLine($"Team {team.Name} does not exist!");
                    }
                    else
                    {
                        User user = new User()
                        {
                            Name = getUserInfo[0]
                        };
                        users.Add(user);
                    }
                }
            }

            teamObj.Users = users;

            for(int i = 0; i < teamsCount; i++)
            {

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
            Creator = string.Empty;
            Name = string.Empty;
            Users = new List<User>();
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}
