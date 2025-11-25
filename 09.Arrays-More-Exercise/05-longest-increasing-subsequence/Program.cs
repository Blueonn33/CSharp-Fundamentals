namespace _05_longest_increasing_subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] sequence = numbers.Split(' ').Select(int.Parse).ToArray();

            List<int> longestIncreasingSubsequence = FindLongestIncreasingSubsequence(sequence);
            Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
        }

        static List<int> FindLongestIncreasingSubsequence(int[] sequence)
        {
            int n = sequence.Length;
            int[] lengths = new int[n];
            int[] previous = new int[n];
            for (int i = 0; i < n; i++)
            {
                lengths[i] = 1;
                previous[i] = -1;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sequence[i] > sequence[j] && lengths[i] < lengths[j] + 1)
                    {
                        lengths[i] = lengths[j] + 1;
                        previous[i] = j;
                    }
                }
            }
            int maxLengthIndex = Array.IndexOf(lengths, lengths.Max());
            List<int> lis = new List<int>();
            while (maxLengthIndex != -1)
            {
                lis.Add(sequence[maxLengthIndex]);
                maxLengthIndex = previous[maxLengthIndex];
            }
            lis.Reverse();
            return lis;
        }
    }
}
