namespace _03_rounding_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                double num = arr[i];
                int rounded = (int)Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {rounded}");
            }
        }
    }
}
