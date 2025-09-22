namespace _02_change_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] symbols = command.Split(' ');

                if (symbols[0] == "Delete")
                {
                    numbers.RemoveAll(num => num == int.Parse(symbols[1]));
                }
                else if(symbols[0] == "Insert")
                {
                    numbers.Insert(int.Parse(symbols[2]), int.Parse(symbols[1]));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
