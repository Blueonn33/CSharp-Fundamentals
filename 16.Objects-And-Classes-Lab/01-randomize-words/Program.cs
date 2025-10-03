namespace _01_randomize_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split();
            Random random = new Random();

            words = words.OrderBy(w => random.Next()).ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
