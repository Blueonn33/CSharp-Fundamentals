using System;
using System.Linq;

namespace _01_valid_usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();

            foreach (string username in usernames)
            {
                if (IsValidUsername(username))
                {
                    validUsernames.Add(username);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }

        private static bool IsValidUsername(string username)
        {
            bool result = false;

            if (username.Length > 3 && username.Length < 16)
            {
                result = username.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_');
            }

            return result;
        }
    }
}
