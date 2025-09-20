namespace _05_multiplication_sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            numbers.Add(num1);
            numbers.Add(num2);
            numbers.Add(num3);

            int positiveCounter = 0;
            int negativeCounter = 0;
            bool zero = false;

            for(int i = 0; i < 3; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeCounter++;
                }
                else if(numbers[i] > 0)
                {
                    positiveCounter++;
                }
                else if (numbers[i] == 0)
                {
                    zero = true;
                }
            }

            if(positiveCounter == 3 || negativeCounter == 2)
            {
                Console.WriteLine("positive");
            }
            else if(negativeCounter != 2 && !zero)
            {
                Console.WriteLine("negative");
            }
            else if(zero)
            {
                Console.WriteLine("zero");
            }    
        }
    }
}
