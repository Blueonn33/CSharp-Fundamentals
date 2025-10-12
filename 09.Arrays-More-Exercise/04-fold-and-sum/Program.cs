namespace _04_fold_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4; 
            int[] firstRow = new int[2 * k];
            int[] secondRow = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = numbers[k - 1 - i];
            }

            for (int i = 0; i < k; i++)
            {
                firstRow[i + k] = numbers[numbers.Length - 1 - i];
            }

            for (int i = k; i < numbers.Length - k; i++)
            {
                secondRow[i - k] = numbers[i];
            }

            int[] result = new int[2 * k];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
