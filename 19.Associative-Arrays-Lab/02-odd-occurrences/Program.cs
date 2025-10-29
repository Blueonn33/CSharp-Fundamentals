namespace _02_odd_occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            List<string> oddOccurrences = new List<string>();

            foreach (var kvp in wordCounts)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddOccurrences.Add(kvp.Key);
                }
            }   

            Console.WriteLine(string.Join(" ", oddOccurrences));
        }
    }
}
