namespace _07_list_manipulation_advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool changed = false;

            while (command != "end")
            {
                string[] symbols = command.Split(' ');

                switch (symbols[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(symbols[1]));
                        changed = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(symbols[1]));
                        changed = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(symbols[1]));
                        changed = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(symbols[2]), int.Parse(symbols[1]));
                        changed = true;
                        break;
                    case "Contains":
                        if(numbers.Contains(int.Parse(symbols[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintOdd":
                        List<int> odds = numbers.FindAll(num => num % 2 != 0);
                        Console.WriteLine(string.Join(" ", odds));
                        break;
                    case "PrintEven":
                        List<int> evens = numbers.FindAll(num => num % 2 == 0);
                        Console.WriteLine(string.Join(" ", evens));
                        break;
                    case "GetSum":
                        int sum = 0;
                        foreach(int num in numbers)
                        {
                            sum += num;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string operand = symbols[1];
                        int result = int.Parse(symbols[2]);

                        filter(operand, result, numbers);
                        break;
                }

                command = Console.ReadLine();
            }

            if(changed)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        public static void filter(string operand, int result, List<int> numbers)
        {
            List<int> filtered = new List<int>();

            switch (operand)
            {
                case ">":
                    filtered = numbers.FindAll(num => num > result);
                    break;
                case "<":
                    filtered = numbers.FindAll(num => num < result);
                    break;
                case ">=":
                    filtered = numbers.FindAll(num => num >= result);
                    break;
                case "<=":
                    filtered = numbers.FindAll(num => num <= result);
                    break;
            }
            Console.WriteLine(string.Join(" ", filtered));
        }
    }
}
