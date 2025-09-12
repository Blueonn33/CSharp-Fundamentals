namespace _10_pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceBetweenTargetsM = int.Parse(Console.ReadLine());
            int exhaustionY = int.Parse(Console.ReadLine());

            int pokedTargets = 0;
            int initialPower = powerN;

            while(initialPower >= distanceBetweenTargetsM)
            {
                pokedTargets++;
                initialPower -= distanceBetweenTargetsM;

                if(initialPower == (powerN / 2) && exhaustionY != 0)
                {
                    initialPower /= exhaustionY;
                }
            }

            Console.WriteLine(initialPower);
            Console.WriteLine(pokedTargets);
        }
    }
}
