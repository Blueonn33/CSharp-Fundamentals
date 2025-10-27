namespace _06_vehicle_catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            List<Vehicle> vehicles = new List<Vehicle>();
            double averageCarHorsePower = 0;
            double averageTruckHorsePower = 0;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] vehicleInfo = command.Split();
                string type = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsePower = int.Parse(vehicleInfo[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
            }

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == command);
                vehicle.DisplayInfo();
            }

            List<Vehicle> cars = vehicles.Where(v => v.Type == "car").ToList();
            List<Vehicle> trucks = vehicles.Where(v => v.Type == "truck").ToList();

            if (cars.Count > 0)
            {
                averageCarHorsePower = cars.Average(c => c.HorsePower);
            }
            if (trucks.Count > 0)
            {
                averageTruckHorsePower = trucks.Average(t => t.HorsePower);
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:f2}.");
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public void DisplayInfo()
        {
            string typeCapitalized = char.ToUpper(this.Type[0]) + this.Type.Substring(1);

            Console.WriteLine($"Type: {typeCapitalized}");
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Horsepower: {this.HorsePower}");
        }
    }
}
