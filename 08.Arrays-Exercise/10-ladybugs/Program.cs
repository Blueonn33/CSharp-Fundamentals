namespace _10_ladybugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            for (int i = 0; i < positions.Length; i++)
            {
                if (positions[i] >= 0 && positions[i] < fieldSize)
                {
                    field[positions[i]] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandResults = command.Split(' ');
                int position = int.Parse(commandResults[0]);
                string direction = commandResults[1];
                int flyLength = int.Parse(commandResults[2]);

                if (position < 0 || position >= fieldSize || field[position] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                field[position] = 0;

                if (direction == "right")
                {
                    int newPos = position + flyLength;
                    while (newPos < fieldSize && field[newPos] == 1)
                    {
                        newPos += flyLength;
                    }
                    if (newPos < fieldSize)
                    {
                        field[newPos] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int newPos = position - flyLength;
                    while (newPos >= 0 && field[newPos] == 1)
                    {
                        newPos -= flyLength;
                    }
                    if (newPos >= 0)
                    {
                        field[newPos] = 1;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
