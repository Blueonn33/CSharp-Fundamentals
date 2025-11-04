namespace _05_courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            Dictionary<string, (int studentsCount, List<string> studentNames)> courses = new();

            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] commandParts = command.Split(" : ");
                string courseName = commandParts[0];
                string studentName = commandParts[1];
                List<string> studentNames = new();
                studentNames.Add(studentName);

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = (1, studentNames);
                }
                else
                {
                    courses[courseName].studentNames.Add(studentName);
                    courses[courseName] = (courses[courseName].studentsCount + 1, courses[courseName].studentNames);
                }
            }

            foreach (var (courseName, studentsCount) in courses)
            {
                Console.WriteLine($"{courseName}: {studentsCount.studentsCount}");

                foreach (var student in studentsCount.studentNames)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
