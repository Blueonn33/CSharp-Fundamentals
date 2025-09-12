namespace _07_equal_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] second = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            int i = 0;
            bool identical = true;

            while (identical && i < first.Length)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    identical = false;
                }
                else
                {
                    sum += first[i];
                }

                i++;
            }

            if(identical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
