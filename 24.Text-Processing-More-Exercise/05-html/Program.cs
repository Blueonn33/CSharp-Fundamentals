namespace _05_html
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();
            string comment = "";

            string result = $"<h1>\n  {articleTitle}\n</h1>\n" +
                            $"<article>\n  {articleContent}\n</article>\n";

            while (true)
            {
                comment = Console.ReadLine();

                if (comment == "end of comments")
                {
                    break;
                }

                result += $"<div>\n  {comment}\n</div>\n";
            }

            Console.WriteLine(result);
        }
    }
}
