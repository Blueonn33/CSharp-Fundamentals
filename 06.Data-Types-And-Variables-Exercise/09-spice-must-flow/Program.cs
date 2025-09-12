namespace _09_spice_must_flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalSpice = 0;

            while (startingYield >= 100)
            {
                days++;
                totalSpice += startingYield;
                totalSpice -= 26;
                startingYield -= 10;
            }

            Console.WriteLine(days);
            totalSpice = totalSpice < 26 ? 0 : totalSpice - 26;
            Console.WriteLine(totalSpice);
        }
    }
}
