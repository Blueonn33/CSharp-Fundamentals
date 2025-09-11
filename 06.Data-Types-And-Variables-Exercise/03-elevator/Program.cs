namespace _03_elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double result = 0;
            

            if(capacity > people)
            {
                result = 1;
            }
            else
            {
                result = (int)(Math.Ceiling((double)people / capacity));
            }
            Console.WriteLine(result);
        }
    }
}
