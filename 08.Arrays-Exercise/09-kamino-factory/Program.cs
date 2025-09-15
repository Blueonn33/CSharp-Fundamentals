using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_kamino_factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxSequenceLength = 0;    
            int maxSequenceStartIndex = int.MaxValue; 
            int maxSum = 0;                 
            int bestSampleIndex = 0;        
            int currentSampleIndex = 0;     
            int[] bestSequence = new int[n];

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    break;
                }

                int[] samples = command.Split('!', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                currentSampleIndex++;

                int currentBestLength = 0;
                int currentStartIndex = 0;
                int currentLength = 0;
                int sum = samples.Sum();

                for (int i = 0; i < n; i++)
                {
                    if (samples[i] == 1)
                    {
                        currentLength++;
                        if (currentLength > currentBestLength)
                        {
                            currentBestLength = currentLength;
                            currentStartIndex = i - currentLength + 1;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                    }
                }

                bool isBetter = false;

                if (currentBestLength > maxSequenceLength)
                {
                    isBetter = true;
                }
                else if (currentBestLength == maxSequenceLength)
                {
                    if (currentStartIndex < maxSequenceStartIndex)
                    {
                        isBetter = true;
                    }
                    else if (currentStartIndex == maxSequenceStartIndex && sum > maxSum)
                    {
                        isBetter = true;
                    }
                }

                if (isBetter)
                {
                    maxSequenceLength = currentBestLength;
                    maxSequenceStartIndex = currentStartIndex;
                    maxSum = sum;
                    bestSampleIndex = currentSampleIndex;
                    bestSequence = samples.ToArray();
                }
            }

            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
