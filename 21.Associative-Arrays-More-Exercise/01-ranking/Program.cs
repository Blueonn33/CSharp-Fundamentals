namespace _01_ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPasswords = new();
            Dictionary<string, Dictionary<string, int>> userContests = new();
            string input = "";

            while (true)
            {
                input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] contestData = input.Split(":");
                string contestName = contestData[0];
                string contestPassword = contestData[1];

                contestPasswords[contestName] = contestPassword;
            }

            while (true)
            {
                input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] submissionData = input.Split("=>");
                string contestName = submissionData[0];
                string contestPassword = submissionData[1];
                string username = submissionData[2];
                int points = int.Parse(submissionData[3]);

                if (contestPasswords.ContainsKey(contestName) && contestPasswords[contestName] == contestPassword)
                {
                    
                }
            }
        }
    }
}
