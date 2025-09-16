namespace _07_repeat_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());

            repeatText(text, times);
        }

        public static void repeatText(string text, int times)
        {
            string result = "";

            for(int i = 0; i < times; i++)
            {
                result += text;
            }

            Console.WriteLine(result);
        }
    }
}
