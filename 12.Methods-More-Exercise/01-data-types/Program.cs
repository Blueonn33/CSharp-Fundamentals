namespace _01_data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string input = Console.ReadLine();
            checkDataType(dataType, input);
        }

        public static void checkDataType(string dataType, string input)
        {
            switch (dataType)
            {
                case "int":
                    Console.WriteLine(int.Parse(input) * 2);
                    break;
                case "real":
                    Console.WriteLine($"{(float.Parse(input) * 1.5):F2}");
                    break;
                case "string":
                    Console.WriteLine($@"${input}$");
                    break;
            }
        }
    }
}
