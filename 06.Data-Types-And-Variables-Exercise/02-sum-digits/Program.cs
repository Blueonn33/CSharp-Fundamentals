namespace _02_sum_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            foreach (char num in number)
            {
                sum += int.Parse(num.ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
