namespace _06_strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 1;
            int total = 0;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 1; j <= Char.GetNumericValue(number[i]); j++)
                {
                    sum *= j;
                }
                total += sum;
                sum = 1;
            }

            if (total == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
