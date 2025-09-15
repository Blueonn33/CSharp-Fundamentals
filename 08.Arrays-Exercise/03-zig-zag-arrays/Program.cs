namespace _03_zig_zag_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            int[] numbers = new int[2];

            for (int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    first[i] = numbers[0];
                    second[i] = numbers[1];
                }
                else
                {
                    first[i] = numbers[1];
                    second[i] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}
