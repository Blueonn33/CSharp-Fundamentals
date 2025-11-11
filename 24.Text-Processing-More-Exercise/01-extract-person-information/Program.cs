namespace _01_extract_person_information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Dictionary<string, int> personData = new();

            for (int i = 0; i < rows; i++)
            {
                string text = Console.ReadLine();
                string name = Extract(text, '@', '|');
                string age = Extract(text, '#', '*');

                personData[name] = int.Parse(age);
            }

            foreach (var (key, value) in personData)
            {
                Console.WriteLine($"{key} is {value} years old.");
            }
        }

        private static string Extract(string text, char start, char end)
        {
            int firstIndex = text.IndexOf(start);
            int lastIndex = text.LastIndexOf(end);
            string result = text.Substring(firstIndex + 1, lastIndex - firstIndex - 1);

            return result;
        }
    }
}
