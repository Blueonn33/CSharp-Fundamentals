namespace _06_replace_repeating_chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //foreach (char symb in text)
            //{
            //    int lastIndex = text.LastIndexOf(symb);

            //}

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                int lastIndex = text.LastIndexOf(symbol);

                //text = text.Replace(new string(symbol, 2));
            }
        }
    }
}
