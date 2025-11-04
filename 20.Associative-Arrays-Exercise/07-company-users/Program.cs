namespace _07_company_users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Dictionary<string, List<string>> companies = new();

            while (true)
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] commandParts = command.Split(" -> ");
                string companyName = commandParts[0];
                string employeeId = commandParts[1];

                if (companies.ContainsKey(companyName))
                {
                    companies[companyName].Add(employeeId);
                }
                else
                {
                    companies[companyName] = new List<string>() { employeeId };
                }
            }

            foreach( var (companyName, employeeIds) in companies)
            {
                Console.WriteLine(companyName);
                HashSet<string> uniqueEmployeeIds = new HashSet<string>(employeeIds);

                foreach (var employeeId in uniqueEmployeeIds)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
