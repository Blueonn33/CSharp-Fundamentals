namespace _07_max_sequence_of_equal_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

            List<int> currentSequence = new List<int> { numbers[0] };
            List<int> longestSequence = new List<int> { numbers[0] };

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequence.Add(numbers[i]);
                }
                else
                {
                    currentSequence = new List<int> { numbers[i] };
                }

                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }
            }

            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}
