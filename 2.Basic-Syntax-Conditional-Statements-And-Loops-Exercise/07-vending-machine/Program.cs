namespace _07_vending_machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            double counter = 0;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Start")
                {
                    break;
                }
                if (command != "0.1" && command != "0.2" && command != "0.5" && command != "1" && command != "2")
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
                else
                {
                    counter += double.Parse(command);
                }
            }
            while (true)
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine($"Change: {counter:f2}");
                    break;
                }
                switch (command)
                {
                    case "Nuts":
                        if (counter < 2)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        counter -= 2;
                        Console.WriteLine("Purchased nuts");
                        break;
                    case "Water":
                        if (counter < 0.7)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        counter -= 0.7;
                        Console.WriteLine("Purchased water");
                        break;
                    case "Crisps":
                        if (counter < 1.5)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        counter -= 1.5;
                        Console.WriteLine("Purchased crisps");
                        break;
                    case "Soda":
                        if (counter < 0.8)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        counter -= 0.8;
                        Console.WriteLine("Purchased soda");
                        break;
                    case "Coke":
                        if (counter < 1)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        counter -= 1;
                        Console.WriteLine("Purchased coke");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
        }
    }
}
