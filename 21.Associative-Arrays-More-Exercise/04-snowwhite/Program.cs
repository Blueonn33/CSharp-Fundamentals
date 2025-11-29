using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new List<(string Name, string HatColor, int Physics)>();
            string command;

            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] dwarfInfo = command.Split(" <:> ");
                string name = dwarfInfo[0];
                string hatColor = dwarfInfo[1];
                int physics = int.Parse(dwarfInfo[2]);

                var existing = dwarfs.FirstOrDefault(d => d.Name == name && d.HatColor == hatColor);
                if (existing != default)
                {
                    if (physics > existing.Physics)
                    {
                        dwarfs.Remove(existing);
                        dwarfs.Add((name, hatColor, physics));
                    }
                }
                else
                {
                    dwarfs.Add((name, hatColor, physics));
                }
            }

            var ordered = dwarfs
                .OrderByDescending(d => d.Physics)
                .ThenByDescending(d => dwarfs.Count(x => x.HatColor == d.HatColor))
                .ToList();

            foreach (var dwarf in ordered)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}