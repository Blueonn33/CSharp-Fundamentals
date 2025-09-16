namespace _08_math_power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(calculate(num, power));
        }

        public static double calculate(double num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}
