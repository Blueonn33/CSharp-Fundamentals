namespace _11_array_manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] parts = command.Split(' ');

                switch (parts[0])
                {
                    case "exchange":
                        int index = int.Parse(parts[1]);
                        if (index < 0 || index >= numbers.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers = Exchange(numbers, index);
                        }
                        break;

                    case "max":
                        PrintMaxIndex(numbers, parts[1]);
                        break;

                    case "min":
                        PrintMinIndex(numbers, parts[1]);
                        break;

                    case "first":
                        int countFirst = int.Parse(parts[1]);
                        if (countFirst > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            PrintFirst(numbers, countFirst, parts[2]);
                        }
                        break;

                    case "last":
                        int countLast = int.Parse(parts[1]);
                        if (countLast > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            PrintLast(numbers, countLast, parts[2]);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        static int[] Exchange(int[] numbers, int index)
        {
            int[] result = new int[numbers.Length];
            int pos = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                result[pos++] = numbers[i];
            }

            for (int i = 0; i <= index; i++)
            {
                result[pos++] = numbers[i];
            }

            return result;
        }

        static void PrintMaxIndex(int[] numbers, string type)
        {
            int remainder = type == "even" ? 0 : 1;
            int max = int.MinValue;
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == remainder)
                {
                    if (numbers[i] >= max)
                    {
                        max = numbers[i];
                        index = i;
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void PrintMinIndex(int[] numbers, string type)
        {
            int remainder = type == "even" ? 0 : 1;
            int min = int.MaxValue;
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == remainder)
                {
                    if (numbers[i] <= min)
                    {
                        min = numbers[i];
                        index = i;
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void PrintFirst(int[] numbers, int count, string type)
        {
            int remainder = type == "even" ? 0 : 1;

            List<int> result = numbers.Where(n => n % 2 == remainder).Take(count).ToList();

            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }

        static void PrintLast(int[] numbers, int count, string type)
        {
            int remainder = type == "even" ? 0 : 1;

            List<int> result = numbers.Where(n => n % 2 == remainder).Reverse().Take(count).Reverse().ToList();

            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
    }
}
