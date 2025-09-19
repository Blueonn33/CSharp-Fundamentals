namespace _06_middle_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            printMiddle(text);
        }

        public static void printMiddle(string text)
        {
            string result = "";
            int size = text.Length;

            if(size % 2 == 0)
            {
                result += text[(size / 2) - 1];
                result += text[size / 2];
            }
            else
            {
                result += text[size / 2];
            }

            Console.WriteLine(result);
        }
    }
}
