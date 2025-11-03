namespace _04_softuni_parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < counter; i++)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split(' ');

                string action = commandParts[0];
                string username = commandParts[1];

                if (action == "register")
                {
                    string plate = commandParts[2];
                    if (parkingLot.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                    else
                    {
                        parkingLot[username] = plate;
                        Console.WriteLine($"{username} registered {plate} successfully");
                    }
                }
                else if (action == "unregister")
                {
                    if (!parkingLot.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkingLot.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var (user, plate) in parkingLot)
            {
                Console.WriteLine($"{user} => {plate}");
            }
        }
    }
}
