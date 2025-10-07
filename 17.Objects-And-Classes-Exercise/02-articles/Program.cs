using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _02_articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputText = input.Split(", ");

            Article article = new Article()
            {
                Title = inputText[0],
                Content = inputText[1],
                Author = inputText[2],
            };

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string command = Console.ReadLine();
                string[] getCommands = command.Split(" ");
                string commandText = getCommands[0];
                string commandValue = "";

                for (int j = 1; j < getCommands.Length; j++)
                {
                    commandValue += getCommands[j];
                    if (j < getCommands.Length - 1)
                    {
                        commandValue += " ";
                    }
                }

                switch (commandText)
                {
                    case "Edit:":
                        article.Edit(article, commandValue);
                        break;
                    case "ChangeAuthor:":
                        article.ChangeAuthor(article, commandValue);
                        break;
                    case "Rename:":
                        article.Rename(article, commandValue);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article()
        {
            Title = string.Empty;
            Content = string.Empty;
            Author = string.Empty;
        }

        public void Edit(Article article, string content)
        {
            article.Content = content;
        }

        public void ChangeAuthor(Article article, string author)
        {
            article.Author = author;
        }

        public void Rename(Article article, string title)
        {
            article.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
