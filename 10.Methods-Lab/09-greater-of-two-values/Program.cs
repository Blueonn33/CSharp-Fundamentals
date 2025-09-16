namespace _09_greater_of_two_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var firstValue = Console.ReadLine();
            var secondValue = Console.ReadLine();

            switch(type)
            {
                case "int":
                    greaterValue(int.Parse(firstValue), int.Parse(secondValue)); 
                    break;
                case "char":
                    greaterValue(char.Parse(firstValue), char.Parse(secondValue));
                    break;
                case "string":
                    greaterValue(firstValue, secondValue);
                    break;
            }
        }

        public static void greaterValue(int first, int second)
        {
            Console.WriteLine(Math.Max(first, second));
        }

        public static void greaterValue(char first, char second)
        {
            Console.WriteLine((char)Math.Max(first, second));
        }

        public static void greaterValue(string first, string second)
        {
            int result = String.Compare(first, second);

            if (result < 0)
            {
                Console.WriteLine(second);
            }
            else if (result > 0)
            {
                Console.WriteLine(first);
            }
        }
    }
}
