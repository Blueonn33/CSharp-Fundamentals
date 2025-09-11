namespace _11_orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int daysInMonth = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double currentOrderPrice = 0;

            while (ordersCount > 0)
            {
                currentOrderPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalPrice += currentOrderPrice;
                Console.WriteLine($"The price for the coffee is: ${currentOrderPrice:f2}");

                ordersCount--;

                if (ordersCount == 0)
                {
                    break;
                }

                pricePerCapsule = double.Parse(Console.ReadLine());
                daysInMonth = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());

                currentOrderPrice = 0;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
