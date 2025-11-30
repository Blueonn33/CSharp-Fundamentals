using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder(Console.ReadLine());
        string command = "";

        while ((command = Console.ReadLine()) != "Abracadabra")
        {
            string[] commandParts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string commandAction = commandParts[0];

            switch (commandAction)
            {
                case "Abjuration":
                    sb = new StringBuilder(sb.ToString().ToUpper());
                    Console.WriteLine(sb);
                    break;

                case "Necromancy":
                    sb = new StringBuilder(sb.ToString().ToLower());
                    Console.WriteLine(sb);
                    break;

                case "Illusion":
                    int index = int.Parse(commandParts[1]);
                    char letter = char.Parse(commandParts[2]);

                    if (index >= 0 && index < sb.Length)
                    {
                        sb[index] = letter;
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                    break;

                case "Divination":
                    string firstSubstring = commandParts[1];
                    string secondSubstring = commandParts[2];

                    if (sb.ToString().Contains(firstSubstring))
                    {
                        sb = new StringBuilder(sb.ToString().Replace(firstSubstring, secondSubstring));
                        Console.WriteLine(sb);
                    }
                    break;

                case "Alteration":
                    string substring = commandParts[1];

                    if (sb.ToString().Contains(substring))
                    {
                        int indexToRemove = sb.ToString().IndexOf(substring);
                        sb.Remove(indexToRemove, substring.Length);
                        Console.WriteLine(sb);
                    }
                    break;

                default:
                    Console.WriteLine("The spell did not work!");
                    break;
            }
        }
    }
}