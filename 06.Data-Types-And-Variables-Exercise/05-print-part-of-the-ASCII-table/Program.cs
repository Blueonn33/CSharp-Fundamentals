namespace _05_print_part_of_the_ASCII_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for(int i = start; i <= end; i++)
            {
                char symbol = (char)i;
                Console.Write(symbol + " ");
            }
        }
    }
}
