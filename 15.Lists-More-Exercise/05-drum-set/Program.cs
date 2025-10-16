using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _05_drum_set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            List<int> drumSetOriginal = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> drumSet = new List<int>(drumSetOriginal);
            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);
                for (int i = drumSet.Count - 1; i >= 0; i--)
                {
                    drumSet[i] -= power;
                    double price = drumSetOriginal[i] * 3;
                    if (drumSet[i] <= 0)
                    {
                        if (savings >= price)
                        {
                            drumSet[i] = drumSetOriginal[i];
                            savings -= price;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            drumSetOriginal.RemoveAt(i);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings.ToString("F2", CultureInfo.InvariantCulture)}lv.");
        }
    }
}