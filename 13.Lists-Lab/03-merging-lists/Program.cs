using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_merging_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int size = Math.Min(first.Count, second.Count);

            for (int i = 0; i < size; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }

            if (first.Count > second.Count)
            {
                for (int i = size; i < first.Count; i++)
                {
                    result.Add(first[i]);
                }
            }
            else
            {
                for (int i = size; i < second.Count; i++)
                {
                    result.Add(second[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
