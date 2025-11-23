string message = Console.ReadLine();
string command = null;

while ((command = Console.ReadLine()) != "Reveal")
{
    string[] tokens = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
    string action = tokens[0];

    switch (action)
    {
        case "ChangeAll":
            message = ChangeAll(tokens[1], tokens[2], message);
            break;
        case "Reverse":
            message = Reverse(tokens[1], message);
            break;
        case "InsertSpace":
            break;

    }
}

Console.WriteLine($"You have a new text message: {message}");

static string ChangeAll(string substring, string replacement, string message)
{
    message = message.Replace(substring, replacement);

    Console.WriteLine(message);

    return message;
}

static string Reverse(string substring, string message)
{
    int index = message.IndexOf(substring);

    if(index != -1)
    {
        string beforeSubstring = message.Substring(0, index);
        string afterSubstring = message.Substring(index + substring.Length);

        char[] reversedChars = substring.Reverse().ToArray();
        string reversed = new string(reversedChars);

        message = beforeSubstring + afterSubstring + reversed;
    }
    else
    {
        Console.WriteLine("Error");
    }

    Console.WriteLine(message);
     
    return message;
}