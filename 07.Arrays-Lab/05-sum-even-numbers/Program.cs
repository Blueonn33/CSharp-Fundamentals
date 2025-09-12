namespace _05_sum_even_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int sum = 0;

            foreach(string num in arr)
            {
                int n = int.Parse(num);

                if(n % 2 == 0)
                {
                    sum += n;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
