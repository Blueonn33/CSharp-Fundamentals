namespace _03_vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double total = 0;

            switch (day)
            {
                case "Friday":
                    price = type == "Students" ? 8.45 :
                            type == "Business" ? 10.90 :
                            type == "Regular" ? 15 : 0;
                    break;
                case "Saturday":
                    price = type == "Students" ? 9.80 :
                            type == "Business" ? 15.60 :
                            type == "Regular" ? 20.00 : 0;
                    break;
                case "Sunday":
                    price = type == "Students" ? 10.46 :
                            type == "Business" ? 16.00 :
                            type == "Regular" ? 22.50 : 0;
                    break;
            }

            if (type == "Students")
            {
                total = count * price;
                if (count >= 30)
                {
                    total -= (total * 0.15);
                }
            }
            else if (type == "Business")
            {
                count = count >= 100 ? count - 10 : count;
                total = count * price;
            }
            else if (type == "Regular")
            {
                total = count * price;
                if (count >= 10 && count <= 20)
                {
                    total -= (total * 0.05);
                }
            }
            Console.WriteLine($"Total price: {total:F2}");
        }
    }
}
