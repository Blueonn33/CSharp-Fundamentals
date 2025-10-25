namespace _01_company_roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeCount = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            decimal highestAverageSalary = 0;
            string departmentWithHighestAverageSalary = "";
            decimal departmentAverageSalary = 0;

            for (int i = 0; i < employeeCount; i++)
            {
                string employeeData = Console.ReadLine();
                string[] parts = employeeData.Split();

                Employee employee = new Employee(
                    parts[0],
                    decimal.Parse(parts[1]),
                    parts[2]
                );

                employees.Add(employee);
            }

            employees.OrderBy(e => e.Department);

            for (int i = 0; i < employeeCount; i++)
            {
                departmentAverageSalary = employees
                    .Where(e => e.Department == employees[i].Department)
                    .Select(e => e.Salary)
                    .Average();

                if (departmentAverageSalary > highestAverageSalary)
                {
                    highestAverageSalary = departmentAverageSalary;
                    departmentWithHighestAverageSalary = employees[i].Department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {departmentWithHighestAverageSalary}");
            foreach (var employee in employees
                         .Where(e => e.Department == departmentWithHighestAverageSalary)
                         .OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
}

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
    public Employee(string name, decimal salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }
}