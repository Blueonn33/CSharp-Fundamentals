namespace _03_moba_challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Dictionary<string, Dictionary<string, int>> playerPositions = new();

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Season end")
                {
                    break;
                }

                string[] commandData = command.Split(" -> ");
                string player = commandData[0];
                string position = commandData[1];
                int skillPoints = int.Parse(commandData[2]);

                

                if (!playerPositions.ContainsKey(player))
                {
                    playerPositions[player] = new Dictionary<string, int>();
                    playerPositions[player][position] = skillPoints;
                }
                else
                {
                    playerPositions[player].Add(position, skillPoints );
                }

                
            }
        }
    }
}
