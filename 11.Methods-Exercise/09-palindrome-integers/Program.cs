namespace _09_palindrome_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            palindromeCheck();
        }

        public static void palindromeCheck()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string firstHalf = "";
                string secondHalf = "";

                if (command.Length == 1)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    for (int i = 0; i < command.Length / 2; i++)
                    {
                        firstHalf += command[i];
                    }

                    if (command.Length % 2 == 0)
                    {
                        for (int i = command.Length - 1; i >= command.Length / 2; i--)
                        {
                            secondHalf += command[i];
                        }
                    }
                    else
                    {
                        for (int i = command.Length - 1; i > command.Length / 2; i--)
                        {
                            secondHalf += command[i];
                        }
                    }

                    if (firstHalf == secondHalf)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
