namespace _01_sum_adjacent_equal_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int i = 0;

            while(i < numbers.Count - 1)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] *= 2;

                    for (int j = i + 1; j < numbers.Count - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }

                    numbers.RemoveAt(numbers.Count - 1);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
