using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_pokemon_do_not_go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distance = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (distance.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int number;

                if (index < 0)
                {
                    number = distance[0];
                    sum += number;
                    distance.RemoveAt(0);
                    distance.Insert(0, distance[distance.Count - 1]);
                }
                else if (index >= distance.Count)
                {
                    number = distance[distance.Count - 1];
                    sum += number;
                    distance.RemoveAt(distance.Count - 1);
                    distance.Add(distance[0]);
                }
                else
                {
                    number = distance[index];
                    sum += number;
                    distance.RemoveAt(index);
                }

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