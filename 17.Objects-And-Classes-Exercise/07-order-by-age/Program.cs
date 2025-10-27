namespace _07_order_by_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            List<Person> people = new List<Person>();

            while (true)
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] personInfo = command.Split();

                string name = personInfo[0];
                int id = int.Parse(personInfo[1]);
                int age = int.Parse(personInfo[2]);

                Person person = new Person(id, name, age);

                var existingPerson = people.FirstOrDefault(p => p.ID == person.ID);

                if (existingPerson != null)
                {
                    existingPerson.Name = person.Name;
                    existingPerson.Age = person.Age;
                }
                else
                {
                    people.Add(person);
                }
            }

            people = people.OrderBy(p => p.Age).ToList();

            foreach (var personItem in people)
            {
                personItem.DisplayInfo();
            }
        }
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public Person(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{this.Name} with ID: {this.ID} is {this.Age} years old.");
        }
    }

}
