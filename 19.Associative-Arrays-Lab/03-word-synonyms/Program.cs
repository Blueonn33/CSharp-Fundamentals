using System.Linq;

namespace _03_word_synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = "";
            string synonym = "";

            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < 2 * n; i++)
            {
                if (i % 2 == 0)
                {
                    word = Console.ReadLine();

                    if (!words.ContainsKey(word))
                    {
                        words.Add(word, new List<string>());
                    }
                }
                else
                {
                    synonym = Console.ReadLine();
                    words[word].Add(synonym);
                }
            }

            foreach (var w in words)
            {
                Console.WriteLine($"{w.Key} - {string.Join(", ", w.Value)}");
            }
        }
    }
}