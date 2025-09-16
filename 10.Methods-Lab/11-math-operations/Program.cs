namespace _11_math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());

            calculate(action, first, second);
        }

        public static void calculate(string action, int first, int second)
        {
            double result = 0;
            switch(action)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
