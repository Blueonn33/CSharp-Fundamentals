namespace _03_gaming_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            string command = Console.ReadLine();

            while (command != "Game Time" && balance > 0)
            {
                switch (command)
                {
                    case "OutFall 4":
                        if (balance >= 39.99)
                        {
                            balance -= 39.99;
                            totalSpent += 39.99;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance >= 15.99)
                        {
                            balance -= 15.99;
                            totalSpent += 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99)
                        {
                            balance -= 19.99;
                            totalSpent += 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance >= 59.99)
                        {
                            balance -= 59.99;
                            totalSpent += 59.99;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance >= 29.99)
                        {
                            balance -= 29.99;
                            totalSpent += 29.99;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99)
                        {
                            balance -= 39.99;
                            totalSpent += 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                command = Console.ReadLine();
            }

            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2} ");
            }
        }
    }
}
