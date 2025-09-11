namespace _10_rage_expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetBreakCount = 0;
            int mouseBreakCount = 0;

            double totalExpenses = 0;

            while (lostGamesCount > 0)
            {
                if (lostGamesCount % 2 == 0)
                {
                    totalExpenses += headsetPrice;
                    headsetBreakCount++;
                }
                if (lostGamesCount % 3 == 0)
                {
                    totalExpenses += mousePrice;
                    mouseBreakCount++;
                }
                if (headsetBreakCount > 0 && mouseBreakCount > 0 && lostGamesCount % 6 == 0)
                {
                    totalExpenses += keyboardPrice;
                    headsetBreakCount = 0;
                    mouseBreakCount = 0;
                    if (lostGamesCount % 12 == 0)
                    {
                        totalExpenses += displayPrice;
                    }
                }
                lostGamesCount--;
            }

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}
