namespace _10_top_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            topNumbers(n);
        }

        public static void topNumbers(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;
                bool divisibleBy8 = false;
                bool containsOdd = false;

                while(number > 0)
                {
                    int digit = number % 10;
                    sum += digit;
                    number /= 10;

                    if(digit % 2 != 0)
                    {
                        containsOdd = true;
                    }
                }

                if(sum % 8 == 0 && containsOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
