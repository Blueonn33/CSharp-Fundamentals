using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _03_moba_challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Dictionary<string, Dictionary<string, int>> players = new();

            while ((command = Console.ReadLine()) != "Season end")
            {
                string[] playerInput = command.Split(" -> ");
                string name = playerInput[0];
                string role = playerInput[1];
                int skill = int.Parse(playerInput[2]);

                if (playerInput[1] == "vs")
                {
                    if (!players.ContainsKey(playerInput[0]) && !players.ContainsKey(playerInput[2]))
                    {
                        break;
                    }
                    else
                    {
                        string roles = "";

                        foreach (var player in players)
                        {
                            string playerName = player.Key;
                            string player1 = playerInput[0];

                            //players[player1]

                            //Dictionary<string, int> attributes = players[player1].Value;
                            string player2 = playerInput[2];

                            if (playerName == player1)
                            {
                                //Dictionary<string, int> attributes = player.Value;

                                //foreach (var attribute in attributes)
                                //{
                                //    string attributeName = attribute.Key;
                                //    int attributeValue = attribute.Value;
                                //}
                            }

                            

                        }
                    }
                }
                else
                {
                    if (!players.ContainsKey(name))
                    {
                        players[name] = new Dictionary<string, int>();
                        players[name].Add(role, skill);
                    }
                    else
                    {
                        players[name].Add(role, skill);
                    }
                }
            }
        }
    }
}
