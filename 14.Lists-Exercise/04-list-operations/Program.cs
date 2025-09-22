namespace _04_list_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine();
            List<int> numbers = new List<int>();
            if (!string.IsNullOrWhiteSpace(firstLine))
            {
                numbers = firstLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] symbols = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (symbols.Length == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                switch (symbols[0])
                {
                    case "Add":
                        if (symbols.Length >= 2 && int.TryParse(symbols[1], out int addVal))
                        {
                            numbers.Add(addVal);
                        }
                        break;

                    case "Insert":
                        if (symbols.Length >= 3
                            && int.TryParse(symbols[1], out int insertVal)
                            && int.TryParse(symbols[2], out int insertIndex))
                        {
                            if (insertIndex >= 0 && insertIndex <= numbers.Count)
                            {
                                numbers.Insert(insertIndex, insertVal);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid command");
                        }
                        break;

                    case "Remove":
                        if (symbols.Length >= 2 && int.TryParse(symbols[1], out int removeIndex))
                        {
                            if (removeIndex >= 0 && removeIndex < numbers.Count)
                            {
                                numbers.RemoveAt(removeIndex);
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid command");
                        }
                        break;

                    case "Shift":
                        if (symbols.Length >= 3 && int.TryParse(symbols[2], out int count))
                        {
                            if (numbers.Count == 0) break;

                            int k = ((count % numbers.Count) + numbers.Count) % numbers.Count;
                            if (k == 0) break;

                            if (symbols[1] == "left")
                            {
                                for (int i = 0; i < k; i++)
                                {
                                    int first = numbers[0];
                                    numbers.RemoveAt(0);
                                    numbers.Add(first);
                                }
                            }
                            else if (symbols[1] == "right")
                            {
                                for (int i = 0; i < k; i++)
                                {
                                    int lastIndex = numbers.Count - 1;
                                    int last = numbers[lastIndex];
                                    numbers.RemoveAt(lastIndex);
                                    numbers.Insert(0, last);
                                }
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
