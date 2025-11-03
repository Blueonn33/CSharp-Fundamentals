namespace _01_count_chars_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char s in text)
            {
                if (s != ' ')
                {
                    if (charCount.ContainsKey(s))
                    {
                        charCount[s]++;
                    }
                    else
                    {
                        charCount[s] = 1;
                    }
                }
            }

            foreach(var (key, value) in charCount)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
