namespace _05_special_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = " ";
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                int num = i + 1;
                while(num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                if(sum == 5 || sum == 7 || sum == 11)
                {
                    result = "True";
                }
                else
                {
                    result = "False";
                }
                sum = 0;
                Console.WriteLine($"{i + 1} -> {result}");
            }
        }
    }
}
