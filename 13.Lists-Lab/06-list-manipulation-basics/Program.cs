using System.Collections.Generic;

namespace _06_list_manipulation_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] symbols = command.Split(' ');
                switch (symbols[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(symbols[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(symbols[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(symbols[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(symbols[2]), int.Parse(symbols[1]));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
