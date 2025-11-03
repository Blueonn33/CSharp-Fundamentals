namespace _03_orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orderInput = "";
            Dictionary<string, (double price, int quantity)> orders = new Dictionary<string, (double price, int quantity)>();

            while (true)
            {
                orderInput = Console.ReadLine();

                if (orderInput == "buy")
                {
                    break;
                }

                string[] orderParts = orderInput.Split(' ');
                string product = orderParts[0];
                double price = double.Parse(orderParts[1]);
                int quantity = int.Parse(orderParts[2]);

                if (orders.ContainsKey(product))
                {
                    orders[product] = (price, orders[product].quantity + quantity);
                }
                else
                {
                    orders[product] = (price, quantity);
                }
            }

            foreach (var (product, (price, quantity)) in orders)
            {
                Console.WriteLine($"{product} -> {price * quantity:F2}");
            }
        }
    }
}
