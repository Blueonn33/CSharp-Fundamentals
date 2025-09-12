namespace _02_print_numbers_in_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string result = "";

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                result += arr[i] + " ";
            }

            Console.WriteLine(result);
        }
    }
}
