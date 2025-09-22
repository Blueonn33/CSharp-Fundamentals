namespace _03_house_party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            List<string> guestsList = new List<string>();

            for (int i = 0; i < guests; i++)
            {
                string guest = Console.ReadLine();
                string[] symbols = guest.Split(' ');

                if (symbols[2] == "going!")
                {
                    if (guestsList.Contains(symbols[0]))
                    {
                        Console.WriteLine($"{symbols[0]} is already in the list!");
                    }
                    else
                    {
                        guestsList.Add(symbols[0]);
                    }
                }
                else
                {
                    if (guestsList.Contains(symbols[0]))
                    {
                        guestsList.Remove(symbols[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{symbols[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join("\n", guestsList));
        }
    }
}
