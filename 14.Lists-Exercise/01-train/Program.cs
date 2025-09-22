namespace _01_train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] symbols = command.Split(' ');

                if (symbols[0] == "Add")
                {
                    train.Add(int.Parse(symbols[1]));
                }
                else
                {
                    for(int i = 0; i < train.Count; i++)
                    {
                        if (int.Parse(symbols[0]) + train[i] <= wagonCapacity)
                        {
                            train[i] += int.Parse(symbols[0]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
