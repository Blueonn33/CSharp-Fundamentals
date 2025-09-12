namespace _08_beer_kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string biggestKeg = "";
            const double pi = Math.PI;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = pi * Math.Pow(radius, 2) * height;

                if(volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }
            }
            
            Console.WriteLine(biggestKeg);
        }
    }
}
