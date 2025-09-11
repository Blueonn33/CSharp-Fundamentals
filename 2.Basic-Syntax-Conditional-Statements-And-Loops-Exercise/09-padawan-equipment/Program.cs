namespace _09_padawan_equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabers = Math.Ceiling(students * 0.1);
            int belts = students / 6;

            double totalCost = (lightsabers + students) * lightsaberPrice + students * robePrice + (students - belts) * beltPrice;
            if (totalCost <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalCost - money:F2}lv more.");
            }
        }
    }
}
