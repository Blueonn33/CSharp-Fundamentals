namespace _04_word_filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ')
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
