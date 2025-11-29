using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double savings = double.Parse(Console.ReadLine());
        List<int> initial = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> drums = new List<int>(initial);

        string input;
        while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
        {
            int hit = int.Parse(input);

            for (int i = 0; i < drums.Count; i++)
            {
                drums[i] -= hit;

                if (drums[i] <= 0)
                {
                    double price = initial[i] * 3;

                    if (savings >= price)
                    {
                        savings -= price;
                        drums[i] = initial[i];
                    }
                    else
                    {
                        drums.RemoveAt(i);
                        initial.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", drums));
        Console.WriteLine($"Gabsy has {savings:F2}lv.");
    }
}
