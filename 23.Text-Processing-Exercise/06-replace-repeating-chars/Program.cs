using System;

namespace _06_replace_repeating_chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                int j = i + 1;

                while (j < text.Length && text[j] == symbol)
                {
                    j++;
                }

                result += symbol;
                i = j - 1;
            }

            Console.WriteLine(result);
        }
    }
}