namespace _02_character_multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string str1 = input[0];
            string str2 = input[1];

            int result = CharacterMultiplier(str1, str2);
            Console.WriteLine(result);
        }

        private static int CharacterMultiplier(string str1, string str2)
        {
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            int sum = 0;
            int lastIndex = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                sum += arr1[i] * arr2[i];
                lastIndex = i;
            }

            if (arr1.Length != arr2.Length)
            {
                if (arr1.Length > arr2.Length)
                {
                    for (int i = lastIndex + 1; i < arr1.Length; i++)
                    {
                        sum += arr1[i];
                    }
                }
                else
                {
                    for (int i = lastIndex + 1; i < arr2.Length; i++)
                    {
                        sum += arr2[i];
                    }
                }
            }

            return sum;
        }
    }
}
