namespace _04_tribonacci_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            tribonacciSequence(n);
        }

        public static void tribonacciSequence(int n)
        {
            List<int> sequence = new List<int> { 1, 1, 2 };

            if (n >= 4)
            {
                for (int i = 3; i < n; i++)
                {
                    sequence.Add(sequence[i - 1] + sequence[i - 2] + sequence[i - 3]);
                }
                Console.WriteLine(string.Join(" ", sequence));
            }
            else
            {
                for(int i =0; i < n; i++)
                {
                    Console.Write(sequence[i] + " ");
                }
            }
            
        }
    }
}
