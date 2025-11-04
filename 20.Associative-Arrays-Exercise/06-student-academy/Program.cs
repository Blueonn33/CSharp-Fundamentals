namespace _06_student_academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, (double grade, int gradesCount)> students = new Dictionary<string, (double grade, int gradesCount)>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(name))
                {
                    students[name] = (students[name].grade + grade, students[name].gradesCount + 1);
                }
                else
                {
                    students[name] = (grade, 1);
                }
            }

            Dictionary<string, double> averageGrades = new Dictionary<string, double>();

            foreach (var student in students)
            {
                double average = student.Value.grade / student.Value.gradesCount;

                if (average >= 4.50)
                {
                    averageGrades[student.Key] = average;
                }
            }

            foreach (var student in averageGrades)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
