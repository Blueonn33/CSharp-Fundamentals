using System.Globalization;

namespace _06_store_boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[] input = command.Split();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string serialNumber = input[0];
                string name = input[1];
                int itemQuantity = int.Parse(input[2]);
                double price = double.Parse(input[3], CultureInfo.InvariantCulture);

                Item item = new Item()
                {
                    Name = name,
                    Price = price,
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity,
                    Price = item.Price * itemQuantity
                };

                boxes.Add(box);
                command = Console.ReadLine();
                input = command.Split();
            }

            DisplayBoxes(boxes);
        }
        public static void DisplayBoxes(List<Box> boxes)
        {
            List<Box> orderedBoxes = boxes.OrderByDescending(x => x.Price).ToList();
            
            foreach(Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }
    }
}
