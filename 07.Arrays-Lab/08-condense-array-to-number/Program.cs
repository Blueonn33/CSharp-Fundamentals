namespace _08_condense_array_to_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int size = nums.Length;
            int[] condensed = new int[size];
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                if (size == 1)
                {
                    Console.WriteLine(nums[0]);
                    break;
                }
                for (int j = 0; j < size - i - 1; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                    sum += condensed[j];
                }
                nums = condensed;
                size--;
            }

            if(nums.Length != 1)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
