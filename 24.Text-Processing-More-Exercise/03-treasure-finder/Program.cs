namespace _03_treasure_finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            int[] keyParts = keys
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Dictionary<string, string> treasures = new Dictionary<string, string>();

            string message = "";

            while (true)
            {
                message = Console.ReadLine();

                if (message == "find")
                {
                    break;
                }

                int keyIndex = 0;
                string decryptedMessage = "";

                foreach (char symbol in message)
                {
                    int keyPart = keyParts[keyIndex];
                    char decryptedChar = (char)(symbol - keyPart);
                    decryptedMessage += decryptedChar;
                    keyIndex++;

                    if (keyIndex >= keyParts.Length)
                    {
                        keyIndex = 0;
                    }

                }

                int typeStartIndex = decryptedMessage.IndexOf('&') + 1;
                int typeEndIndex = decryptedMessage.IndexOf('&', typeStartIndex);
                string treasureType = decryptedMessage.Substring(typeStartIndex, typeEndIndex - typeStartIndex);

                int coordStartIndex = decryptedMessage.IndexOf('<') + 1;
                int coordEndIndex = decryptedMessage.IndexOf('>', coordStartIndex);
                string coordinates = decryptedMessage.Substring(coordStartIndex, coordEndIndex - coordStartIndex);

                treasures[treasureType] = coordinates;
            }

            foreach (var kvp in treasures)
            {
                Console.WriteLine($"Found {kvp.Key} at {kvp.Value}");
            }
        }
    }
}
