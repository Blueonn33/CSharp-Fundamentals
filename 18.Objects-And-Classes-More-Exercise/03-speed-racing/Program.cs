namespace _03_speed_racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new();
            string command = "";

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split();

                Car car = new Car(carData[0], double.Parse(carData[1]), double.Parse(carData[2]));
                cars.Add(car);
            }

            while (command != "End")
            {
                string[] commandData = Console.ReadLine().Split();

                if(commandData[0] == "End")
                {
                    break;
                }

                string carModel = commandData[1];
                double amountOfKilometers = double.Parse(commandData[2]);

                Car currentCar = cars.First(c => c.Model == carModel);
                currentCar.Drive(currentCar, amountOfKilometers);
            }

            foreach (Car car in cars)
            {
                car.PrintCarInfo();
            }
        }
    }
}

public class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double TraveledDistance { get; set; }

    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        TraveledDistance = 0;
    }

    public void Drive(Car car, double distance)
    {
        double fuelNeeded = car.FuelConsumptionPerKilometer * distance;

        if (fuelNeeded <= car.FuelAmount)
        {
            car.FuelAmount -= fuelNeeded;
            car.TraveledDistance += distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public void PrintCarInfo()
    {
        Console.WriteLine($"{Model} {FuelAmount:f2} {TraveledDistance}");
    }
}