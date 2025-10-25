namespace _04_raw_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split();
                Car car = new Car(
                    carData[0],
                    int.Parse(carData[1]),
                    int.Parse(carData[2]),
                    int.Parse(carData[3]),
                    carData[4]
                );
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> fragileCars = cars.Where(c => c.Cargo.Type == "fragile" && c.Cargo.Weight < 1000)
                    .ToList();

                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                List<Car> flamableCars = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .ToList();

                foreach (var car in flamableCars)
                {
                    Console.WriteLine(car.Model);
                }
            }


        }
    }
}

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }

    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
    {
        Model = model;

        Engine = new Engine
        {
            Speed = engineSpeed,
            Power = enginePower
        };

        Cargo = new Cargo
        {
            Weight = cargoWeight,
            Type = cargoType
        };

    }
}

public class Engine
{
    public int Speed { get; set; }
    public int Power { get; set; }
}

public class Cargo
{
    public int Weight { get; set; }
    public string Type { get; set; }
}