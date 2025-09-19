namespace _02_vowels_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            printVowels(text);
        }

        public static void printVowels(string text)
        {
            char[] vowels = new char[] { 'a', 'o', 'u', 'e', 'i', 'A', 'O', 'U', 'E', 'I' };
            int counter = 0;

            foreach(char symbol in text)
            {
                if(vowels.Contains(symbol))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
