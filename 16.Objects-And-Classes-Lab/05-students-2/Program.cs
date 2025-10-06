namespace _05_students_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[] input = command.Split();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                Student student = students.FirstOrDefault(s => s.FirstName == firstName &&
                    s.LastName == lastName);

                if (student == null)
                {
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }

                command = Console.ReadLine();
                input = command.Split();
            }

            string city = Console.ReadLine();

            DisplayStudents(city, students);
        }

        public static void DisplayStudents(string city, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
