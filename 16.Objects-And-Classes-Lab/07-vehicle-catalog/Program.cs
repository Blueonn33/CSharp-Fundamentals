namespace _07_vehicle_catalog
{
    internal class Program
    {
        /*
        You must read the input, until you receive the "end" command. 
        It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
         */

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[] input = command.Split("/");

            //List<CatalogVehicle> catalog = new List<CatalogVehicle>();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (command != "end")
            {
                string type = input[0];
                string brand = input[1];
                string model = input[2];

                if (type == "Car")
                {
                    int horsePower = int.Parse(input[3]);

                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };

                    cars.Add(car);
                }
                else
                {
                    int weight = int.Parse(input[3]);

                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };

                    trucks.Add(truck);
                }

                command = Console.ReadLine();
                input = command.Split("/");
            }

            CatalogVehicle catalog = new CatalogVehicle()
            {
                Cars = cars,
                Trucks = trucks
            };

            DisplayVehicles(catalog);
        }

        public static void DisplayVehicles(CatalogVehicle catalog)
        {
            List<Car> cars = catalog.Cars.OrderBy(c => c.Brand).ToList();
            List<Truck> trucks = catalog.Trucks.OrderBy(c => c.Brand).ToList();

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class CatalogVehicle
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public CatalogVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}
