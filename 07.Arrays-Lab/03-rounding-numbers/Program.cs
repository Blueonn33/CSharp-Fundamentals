namespace _03_rounding_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] arr = numbers.Split(' ');

            for(int i = 0; i < arr.Length; i++)
            {
                double num = double.Parse(arr[i]);
                Console.WriteLine($"{num} => {Math.Round(num, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
