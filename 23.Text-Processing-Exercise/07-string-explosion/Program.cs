namespace _07_string_explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int explosionStrength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == '>')
                {
                    explosionStrength += int.Parse(text[i + 1].ToString());
                }
                else if (explosionStrength > 0)
                {
                    text = text.Remove(i, 1);
                    explosionStrength--;
                    i--;
                }
            }

            Console.WriteLine(text);
        }
    }
}
