namespace _01_reverse_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            string result = "";
            Dictionary<string, string> reversedWords = new Dictionary<string, string>();

            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    result += command[i];
                }

                reversedWords.Add(command, result);
                result = "";
            }

            foreach (var item in reversedWords)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
