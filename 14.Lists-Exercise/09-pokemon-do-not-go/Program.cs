namespace _09_pokemon_do_not_go
{
    internal class Program
    {
        /*
         5 10 6 3 5
           2
           4
           1
           1
           3
           0
           0
         */
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sum = 0;

            while (distance.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index >= distance.Count)
                {
                    distance.RemoveAt(distance.Count - 1);
                    distance.Add(distance[0]);
                    index = distance.Count - 1;
                }

                int number = distance[index];
                distance.RemoveAt(index);
                sum += number;

                for (int i = 0; i < distance.Count; i++)
                {
                    if (distance[i] <= number)
                    {
                        distance[i] += number;
                    }
                    else
                    {
                        distance[i] -= number;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
