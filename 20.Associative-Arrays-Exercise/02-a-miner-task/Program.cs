namespace _02_a_miner_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                string resource = command;
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources[resource] = quantity;
                }
            }

            foreach (var (key, value) in resources)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
