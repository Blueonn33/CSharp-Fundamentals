namespace _05_remove_negatives_and_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positive = new List<int>();

            for(int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] > 0)
                {
                    positive.Add(list[i]);
                }
            }

            if(positive.Count > 0)
            {
                Console.WriteLine(string.Join(" ", positive));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
