namespace _02_friend_list_maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = "";
            int blacklistedCount = 0;
            int lostCount = 0;

            while (command != "Report")
            {
                command = Console.ReadLine();

                if (command == "Report")
                    break;

                string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commandName = commandParts[0];
                string commandValue = commandParts[1];

                switch (commandName)
                {
                    case "Blacklist":
                        int blacklistedIndex = friends.IndexOf(commandValue);

                        if (blacklistedIndex == -1)
                        {
                            Console.WriteLine($"{commandValue} was not found.");
                        }
                        else
                        {
                            friends[blacklistedIndex] = "Blacklisted";
                            blacklistedCount++;
                            Console.WriteLine($"{commandValue} was blacklisted.");
                        }
                        break;

                    case "Error":
                        int errorIndex = int.Parse(commandValue);

                        if (errorIndex >= 0 && errorIndex < friends.Count)
                        {

                            if (friends[errorIndex] != "Blacklisted" && friends[errorIndex] != "Lost")
                            {
                                lostCount++;
                                Console.WriteLine($"{friends[errorIndex]} was lost due to an error.");
                                friends[errorIndex] = "Lost";
                            }

                        }
                        break;

                    case "Change":
                        string commandValueName = commandParts[2];
                        int changeIndex = int.Parse(commandValue);

                        if (changeIndex >= 0 && changeIndex < friends.Count)
                        {
                            string oldName = friends[changeIndex];
                            friends[changeIndex] = commandValueName;
                            Console.WriteLine($"{oldName} changed his username to {commandValueName}.");
                        }
                        break;
                }
            }

            Console.WriteLine($"Blacklisted names: {blacklistedCount}");
            Console.WriteLine($"Lost names: {lostCount}");

            foreach (string friend in friends)
            {
                Console.Write(friend + " ");
            }
        }
    }
}
