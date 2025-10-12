namespace _01_messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string message = Console.ReadLine();
            List<char> messageChars = message.ToCharArray().ToList();
            string result = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int sumOfDigits = 0;

                while(currentNumber > 0)
                {
                    int digit = currentNumber % 10;
                    sumOfDigits += digit;
                    currentNumber /= 10;
                }

                sumOfDigits = sumOfDigits % messageChars.Count;
                result += messageChars[sumOfDigits];
                messageChars.RemoveAt(sumOfDigits);
            }

            Console.WriteLine(result);
        }
    }
}
