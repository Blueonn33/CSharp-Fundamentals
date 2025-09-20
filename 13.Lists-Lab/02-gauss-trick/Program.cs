namespace _02_gauss_trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> gauss = new List<int>();
            int size = list.Count;
            int j = size - 1;

            for (int i = 0; i < size / 2; i++)
            {
                while(j >= size / 2)
                {
                    gauss.Add(list[i] + list[j]);
                    j--;
                    break;
                }
            }

            if(size % 2 != 0)
            {
                gauss.Add(list[size / 2]);
            }

            Console.WriteLine(string.Join(" ", gauss));
        }
    }
}
