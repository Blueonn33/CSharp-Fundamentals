namespace _03_characters_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            printChars(start, end);
        }

        public static void printChars(char start, char end)
        {
            if ((int)end < (int)start)
            {
                char temp = start;
                start = end;
                end = temp;
            }

            for (int i = (int)start + 1; i < (int)end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
