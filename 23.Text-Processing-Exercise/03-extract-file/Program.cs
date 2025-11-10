namespace _03_extract_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int lastIndexOfSlash = text.LastIndexOf('\\');

            string fileNameWithExtension = text.Substring(lastIndexOfSlash + 1);
            int lastIndexOfDot = fileNameWithExtension.LastIndexOf('.');

            string fileName = fileNameWithExtension.Substring(0, lastIndexOfDot);
            string fileExtension = fileNameWithExtension.Substring(lastIndexOfDot + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
