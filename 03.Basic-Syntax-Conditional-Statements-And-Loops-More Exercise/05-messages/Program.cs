namespace _05_messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int offset = 0;
            string result = "";

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                char mainDigit = command[0];
                int numberOfDigits = command.Length;
                offset = (int)(Char.GetNumericValue(mainDigit) - 2) * 3;

                if (mainDigit == '8' || mainDigit == '9')
                {
                    offset++;
                }

                char letter = (char)(97 + offset + numberOfDigits - 1);

                if (mainDigit == '0')
                {
                    letter = ' ';
                }

                result += letter;
            }

            Console.WriteLine(result);
        }
    }
}
