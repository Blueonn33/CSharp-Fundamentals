namespace _08_anonymous_threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputLines = input.Split(" ").ToList();
            string command = "";

            while(command != "3:1")
            {
                command = Console.ReadLine();
                string[] commandParts = command.Split(" ");

                if (commandParts[0] == "merge")
                {
                    inputLines = Merge(inputLines, int.Parse(commandParts[1]), int.Parse(commandParts[2]));
                }
                if(commandParts[0] == "divide")
                {
                    inputLines = Divide(inputLines, int.Parse(commandParts[1]), int.Parse(commandParts[2]));
                }

            }

            Console.WriteLine(String.Join(" "), inputLines);
        }

        private static List<string> Merge(List<string> inputLines, int v1, int v2)
        {
            inputLines[v1] = string.Join("", inputLines.Skip(v1).Take(v2 - v1 + 1));
            return inputLines;
        }

        private static List<string> Divide(List<string> inputLines, int v1, int v2)
        {
            string elementToDivide = inputLines[v1];
            int partLength = elementToDivide.Length / v2;
            List<string> dividedParts = new List<string>();

            for (int i = 0; i < v2; i++)
            {
                if (i == v2 - 1)
                {
                    dividedParts.Add(elementToDivide.Substring(i * partLength));
                }
                else
                {
                    dividedParts.Add(elementToDivide.Substring(i * partLength, partLength));
                }
            }
            inputLines.RemoveAt(v1);
            inputLines.InsertRange(v1, dividedParts);
            return inputLines;
        }
    }
}
