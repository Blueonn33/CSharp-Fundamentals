namespace _01_sort_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
