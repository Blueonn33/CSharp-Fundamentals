namespace _07_append_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] parts = input.Split('|');
            Array.Reverse(parts);

            List<string> result = new List<string>();

            foreach (string part in parts)
            {
                string[] numbers = part.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(numbers);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
