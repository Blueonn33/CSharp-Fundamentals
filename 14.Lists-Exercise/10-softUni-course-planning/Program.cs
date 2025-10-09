namespace _10_softUni_course_planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string command = "";
            List<string> exercises = new();

            while (command != "course start")
            {
                command = Console.ReadLine();
                string[] getCommands = command.Split(":");

                switch (getCommands[0])
                {
                    case "Add":

                        if (!lessons.Contains(getCommands[1]))
                        {
                            lessons.Add(getCommands[1]);
                        }

                        break;
                    case "Insert":

                        if (!lessons.Contains(getCommands[1]))
                        {
                            lessons.Insert(int.Parse(getCommands[2]), getCommands[1]);
                        }

                        break;
                    case "Remove":
                        lessons.Remove(getCommands[1]);

                        if (exercises.Contains(getCommands[1]))
                        {
                            exercises.Remove(getCommands[1]);
                            lessons.Remove($"{getCommands[1]}-Exercise");
                        }

                        break;
                    case "Swap":
                        int firstIndex = lessons.FindIndex(l => l == getCommands[1]);
                        int secondIndex = lessons.FindIndex(l => l == getCommands[2]);

                        string temp = lessons[firstIndex];
                        lessons[firstIndex] = lessons[secondIndex];
                        lessons[secondIndex] = temp;

                        if (exercises.Contains(getCommands[1]))
                        {
                            lessons.Remove($"{getCommands[1]}-Exercise");
                            lessons.Insert(secondIndex + 1, $"{getCommands[1]}-Exercise");
                        }
                        else if (exercises.Contains(getCommands[2]))
                        {
                            lessons.Remove($"{getCommands[2]}-Exercise");
                            lessons.Insert(firstIndex + 1, $"{getCommands[2]}-Exercise");
                        }

                        break;
                    case "Exercise":
                        if (lessons.Contains(getCommands[1]))
                        {
                            int lessonIndex = lessons.FindIndex(l => l == getCommands[1]);
                            lessons.Insert(lessonIndex + 1, $"{getCommands[1]}-Exercise");
                        }
                        else
                        {
                            lessons.Add(getCommands[1]);
                            lessons.Add($"{getCommands[1]}-Exercise");
                        }

                        exercises.Add(getCommands[1]);
                        break;
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
