namespace _03_chat_logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chatLog = new List<string>();
            string command = "";

            while (command != "end")
            {
                command = Console.ReadLine();

                if (command == "end")
                    break;

                string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandName = commandParts[0];

                switch (commandName)
                {
                    case "Chat":
                        string message = commandParts[1];
                        chatLog.Add(message);
                        break;
                    case "Delete":
                        string messageToDelete = commandParts[1];

                        if (chatLog.Contains(messageToDelete))
                        {
                            chatLog.Remove(messageToDelete);
                        }

                        break;
                    case "Edit":
                        string messageToEdit = commandParts[1];
                        string edited = commandParts[2];
                        int editIndex = chatLog.IndexOf(messageToEdit);

                        if (chatLog.Contains(messageToEdit))
                        {
                            chatLog[editIndex] = edited;
                        }

                        break;
                    case "Pin":
                        string messageToPin = commandParts[1];

                        if (chatLog.Contains(messageToPin))
                        {
                            chatLog.Remove(messageToPin);
                            chatLog.Add(messageToPin);
                        }

                        break;
                    case "Spam":

                        for (int i = 1; i < commandParts.Length; i++)
                        {
                            string spamMessage = commandParts[i];
                            chatLog.Add(spamMessage);
                        }

                        break;
                }
            }

            foreach (var item in chatLog)
            {
                Console.WriteLine(item);
            }
        }
    }
}
