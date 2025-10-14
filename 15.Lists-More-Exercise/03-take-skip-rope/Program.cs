using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_take_skip_rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> symbols = text.ToCharArray().ToList();
            List<int> numbersList = symbols.Where(s => char.IsDigit(s))
                .Select(s => int.Parse(s.ToString())).ToList();
            List<char> nonNumbersList = symbols.Where(s => !char.IsDigit(s)).ToList();

            List<int> takeList = numbersList.Where((n, i) => i % 2 == 0).ToList();
            List<int> skipList = numbersList.Where((n, i) => i % 2 != 0).ToList();

            string result = "";
            int index = 0;

            for (int j = 0; j < takeList.Count; j++)
            {
                int take = takeList[j];
                int skip = j < skipList.Count ? skipList[j] : 0;

                for (int t = 0; t < take && index < nonNumbersList.Count; t++)
                {
                    result += nonNumbersList[index];
                    index++;
                }

                index += skip;

                if (index >= nonNumbersList.Count)
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}