using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_bomb_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> bombs = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNumberValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNumber = specialNumberValues[0];
            int power = specialNumberValues[1];

            while (bombs.Contains(specialNumber))
            {
                int idx = bombs.IndexOf(specialNumber);
                int start = Math.Max(0, idx - power);
                int end = Math.Min(bombs.Count - 1, idx + power);
                int count = end - start + 1;
                bombs.RemoveRange(start, count);
            }

            int sum = bombs.Sum();
            Console.WriteLine(sum);
        }
    }
}
