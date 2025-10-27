using System.Security.Cryptography.X509Certificates;

namespace _05_shopping_spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] peopleData = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();

            foreach (var personData in peopleData)
            {
                string[] personInfo = personData.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                Person person = new Person(name, money);
                people.Add(person);
            }

            input = Console.ReadLine();
            string[] productsData = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Product> products = new List<Product>();

            foreach (var productData in productsData)
            {
                string[] productInfo = productData.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = productInfo[0];
                decimal money = decimal.Parse(productInfo[1]);

                Product product = new Product(name, money);
                products.Add(product);
            }

            string command = "";

            while (command != "END")
            {
                command = Console.ReadLine();

                if (command == "END")
                    break;

                string[] commandInfo = command.Split(' ');
                string personName = commandInfo[0];
                string productName = commandInfo[1];

                Person person = people.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                person.CanAfford(person, product);
            }

            foreach (var person in people)
            {
                person.ShowBagOfProducts(person);
            }
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public decimal Money { get; set; }
    public List<Product> BagOfProducts { get; set; }

    public Person()
    {

    }
    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        BagOfProducts = new List<Product>();
    }

    public void CanAfford(Person person, Product product)
    {
        if (person.Money >= product.Cost)
        {
            Console.WriteLine($"{person.Name} bought {product.Name}");
            person.BagOfProducts.Add(product);
            person.Money -= product.Cost;
        }
        else
        {
            Console.WriteLine($"{person.Name} can't afford {product.Name}");
        }
    }

    public void ShowBagOfProducts(Person person)
    {
        if (person.BagOfProducts.Count == 0)
        {
            Console.WriteLine($"{person.Name} - Nothing bought");
        }
        else
        {
            Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts.Select(p => p.Name))}");
        }
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Cost { get; set; }

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}