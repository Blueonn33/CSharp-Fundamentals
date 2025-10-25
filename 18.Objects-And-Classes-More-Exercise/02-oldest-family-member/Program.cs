using System.Runtime.CompilerServices;

namespace _02_oldest_family_member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] personData = Console.ReadLine().Split();

                Person person = new Person(personData[0], int.Parse(personData[1]));
                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}

public class Family
{
    public List<Person> people;
    public Family()
    {
        people = new List<Person>();
    }

    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public Person GetOldestMember()
    {
        return people.OrderByDescending(p => p.Age).First();
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

