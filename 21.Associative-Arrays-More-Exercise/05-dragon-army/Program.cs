namespace _05_dragon_army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var dragons = new List<(string Color, string Name, int Damage, int Health, int Armor)>();
            string command = "";

            for (int i = 0; i < count; i++)
            {
                command = Console.ReadLine();
                string[] dragonInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string color = dragonInfo[0];
                string name = dragonInfo[1];
                int damage = dragonInfo[2] == "null" ? 45 : int.Parse(dragonInfo[2]);
                int health = dragonInfo[3] == "null" ? 250 : int.Parse(dragonInfo[3]);
                int armor = dragonInfo[4] == "null" ? 10 : int.Parse(dragonInfo[4]);
                var existing = dragons.FirstOrDefault(d => d.Color == color && d.Name == name);

                if(existing != default)
                {
                    dragons.Remove(existing);
                }
                dragons.Add((color, name, damage, health, armor));
            }

            var groupedByColor = dragons
                .GroupBy(d => d.Color)
                .ToDictionary(g => g.Key, g => g.ToList());

            double avgDamage = 0;
            double avgHealth = 0;
            double avgArmor = 0;

            foreach (var colorGroup in groupedByColor)
            {
                avgDamage = colorGroup.Value.Average(d => d.Damage);
                avgHealth = colorGroup.Value.Average(d => d.Health);
                avgArmor = colorGroup.Value.Average(d => d.Armor);

                Console.WriteLine($"{colorGroup.Key}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2})");
                foreach (var dragon in colorGroup.Value.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}
