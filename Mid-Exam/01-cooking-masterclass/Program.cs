namespace _01_cooking_masterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            double sum = 0.0;

            for(int i = 0; i < students; i++)
            {
                double appron = priceApron * (students + Math.Ceiling(students * 0.2));
                double flour = priceFlour * (students - students / 5);
                double eggs = priceEgg * (students * 10);
                sum = appron + flour + eggs;
            }

            if (sum > budget)
            {
                Console.WriteLine($"{(sum - budget):F2}$ more needed.");
            }
            else
            {
                Console.WriteLine($"Items purchased for {sum:F2}$.");
            }
        }
    }
}
