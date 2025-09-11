namespace _05_decrypting_messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int interval = int.Parse(Console.ReadLine());
            string result = "";

            for(int i = 0; i < interval; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int symbol = (int)input + key;
                result += (char)symbol;
            }

            Console.WriteLine(result);
        }
    }
}
