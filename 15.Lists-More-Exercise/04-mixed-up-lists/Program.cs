using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_mixed_up_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int size = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < size; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[secondList.Count - 1 - i]);
            }

            int a, b;
            if (firstList.Count > secondList.Count)
            {
                a = firstList[firstList.Count - 2];
                b = firstList[firstList.Count - 1];
            }
            else
            {
                a = secondList[0];
                b = secondList[1];
            }

            int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            List<int> finalResult = result.Where(x => x > start && x < end).ToList();
            finalResult.Sort();
            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}