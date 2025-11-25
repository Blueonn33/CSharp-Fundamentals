using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_anonymous_threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = parts[0];

                if (action == "merge")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);

                    if (startIndex < 0) startIndex = 0;
                    if (endIndex >= data.Count) endIndex = data.Count - 1;

                    if (startIndex < data.Count && startIndex <= endIndex)
                    {
                        string merged = string.Empty;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            merged += data[i];
                        }

                        data.RemoveRange(startIndex, endIndex - startIndex + 1);
                        data.Insert(startIndex, merged);
                    }
                }
                else if (action == "divide")
                {
                    int index = int.Parse(parts[1]);
                    int partitions = int.Parse(parts[2]);

                    string element = data[index];
                    data.RemoveAt(index);

                    int partSize = element.Length / partitions;
                    int extra = element.Length % partitions;

                    List<string> divided = new List<string>();

                    int currentIndex = 0;
                    for (int i = 0; i < partitions; i++)
                    {
                        int currentPartSize = partSize;
                        if (i == partitions - 1) currentPartSize += extra;

                        divided.Add(element.Substring(currentIndex, currentPartSize));
                        currentIndex += currentPartSize;
                    }

                    data.InsertRange(index, divided);
                }
            }

            Console.WriteLine(string.Join(" ", data));
        }
    }
}