namespace _04_caesar_cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = "";

            foreach (char symb in text)
            {
                result += (char)(symb + 3);
            }

            Console.WriteLine(result);
        }
    }
}
