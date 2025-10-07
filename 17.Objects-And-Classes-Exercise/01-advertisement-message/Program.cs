using System.Diagnostics;

namespace _01_advertisement_message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Phrase phrasesObj = new Phrase()
            {
                PhrasesList = phrases
            };
            Event eventsObj = new Event()
            {
                EventsList = events
            };
            Author authorsObj = new Author()
            {
                AuthorsList = authors
            };
            City citiesObj = new City()
            {
                CitiesList = cities
            };

            int messages = int.Parse(Console.ReadLine());

            for(int i = 0; i < messages; i++)
            {
                Random rnd = new Random();
                Console.WriteLine($"{phrasesObj.PhrasesList[rnd.Next(0, phrases.Count)]} " +
                    $"{eventsObj.EventsList[rnd.Next(0, events.Count)]} " +
                    $"{authorsObj.AuthorsList[rnd.Next(0, authors.Count)]} – " +
                    $"{citiesObj.CitiesList[rnd.Next(0, cities.Count)]}.");
            }
        }
    }

    public class Phrase
    { 
        public List<string> PhrasesList { get; set; }
    }
    public class Event
    {
        public List<string> EventsList { get; set; }
    }
    public class Author
    {
        public List<string> AuthorsList { get; set; }
    }
    public class City
    {
        public List<string> CitiesList { get; set; }
    }
}
