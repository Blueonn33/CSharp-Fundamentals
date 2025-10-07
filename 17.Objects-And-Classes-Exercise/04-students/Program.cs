using System.Collections.Generic;
using System.Diagnostics;

namespace _04_students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string[] studentInfo = input.Split(" ");
                Student student = new Student()
                {
                    FirstName = studentInfo[0],
                    LastName = studentInfo[1],
                    Grade = double.Parse(studentInfo[2])
                };

                students.Add(student);
            }

            List<Student> orderedList = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in orderedList)
            {
                Console.WriteLine(student.Display());
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public string Display()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
}
