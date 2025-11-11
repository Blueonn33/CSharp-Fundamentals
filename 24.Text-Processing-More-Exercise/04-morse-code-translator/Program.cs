namespace _04_morse_code_translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<string, string> morseCode = new Dictionary<string, string>()
            {
                {".-","A"},{"-...","B"},{"-.-.","C"},{"-..","D"},{".","E"},{"..-.","F"},
                {"--.","G"},{"....","H"},{"..","I"},{".---","J"},{"-.-","K"},
                {".-..","L"},{"--","M"},{"-.","N"},{"---","O"},{".--.","P"},
                {"--.-","Q"},{".-.","R"},{"...","S"},{"-","T"},{"..-","U"},
                {"...-","V"},{".--","W"},{"-..-","X"},{"-.--","Y"},{"--..","Z"},
                {"-----","0"},{".----","1"},{"..---","2"},{"...--","3"},{"....-","4"},
                {".....","5"},{"-....","6"},{"--...","7"},{"---..","8"},{"----.","9"},
                {"|", " "}
            };

            string[] morseWords = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (string morseChar in morseWords)
            {
                if (morseCode.ContainsKey(morseChar))
                {
                    result += morseCode[morseChar];
                }
            }

            Console.WriteLine(result);
        }
    }
}
