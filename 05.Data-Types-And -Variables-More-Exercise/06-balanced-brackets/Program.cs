namespace _06_balanced_brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char openingBracket = '(';
            char closingBracket = ')';
            bool isOpened = false;
            bool isClosed = false;
            string result = "BALANCED";

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                foreach (char symb in command)
                {
                    if (symb == openingBracket)
                    {
                        if (isOpened)
                        {
                            result = "UNBALANCED";
                        }
                        else
                        {
                            isOpened = true;
                        }
                    }
                    if (symb == closingBracket)
                    {
                        isClosed = true;
                        if (!isOpened)
                        {
                            result = "UNBALANCED";
                        }
                        else
                        {
                            isOpened = false;
                            isClosed = false;
                        }
                    }
                }
            }

            if (isOpened && result == "BALANCED")
            {
                result = "UNBALANCED";
            }

            Console.WriteLine(result);
        }
    }
}
