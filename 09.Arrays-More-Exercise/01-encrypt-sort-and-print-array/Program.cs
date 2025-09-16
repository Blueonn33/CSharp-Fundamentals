namespace _01_encrypt_sort_and_print_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                foreach (char symb in name)
                {
                    if (vowels.Contains(symb))
                    {
                        total += (int)symb * name.Length;
                    }
                    else
                    {
                        total += (int)symb / name.Length;
                    }
                }
                result.Add(total);
                total = 0;
            }

            result.Sort();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
