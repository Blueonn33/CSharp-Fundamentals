namespace _03_articles_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for(int i = 0; i < commands; i++)
            {
                string input = Console.ReadLine();
                string[] getCommands = input.Split(", ");

                Article article = new Article()
                {
                    Title = getCommands[0],
                    Content = getCommands[1],
                    Author = getCommands[2]
                };

                articles.Add(article);
            }

            foreach(Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
