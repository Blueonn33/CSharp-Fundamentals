namespace _02_car_race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> times = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            double leftTime = 0;
            double rightTime = 0;

            for(int i = 0; i < times.Count / 2; i++)
            {
                leftTime += times[i];

                if (times[i] == 0)
                {
                    leftTime *= 0.8;
                }
            }

            for(int i = times.Count - 1; i > times.Count / 2; i--)
            {
                rightTime += times[i];
                if (times[i] == 0)
                {
                    rightTime *= 0.8;
                }
            }

            if (leftTime < rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime.ToString("0.##")}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime.ToString("0.##")}");
            }
        }
    }
}
