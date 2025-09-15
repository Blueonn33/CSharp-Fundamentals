namespace _05_top_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();
            List<int> topIntegers = new List<int>();

            int k = 0;
            bool isTopInteger = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        isTopInteger = true;
                    }
                    else
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topIntegers.Add(numbers[i]);
                    k++;
                }
            }

            if(!topIntegers.Contains(numbers[numbers.Length - 1]))
            {
                topIntegers.Add(numbers[numbers.Length - 1]);
            }

            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}
