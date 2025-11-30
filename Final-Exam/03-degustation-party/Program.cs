Dictionary<string, List<string>> guests = new();
int dislikedMealsCount = 0;
string command = "";

while ((command = Console.ReadLine()) != "Stop")
{
    string[] commandParts = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
    string action = commandParts[0];
    string guestName = commandParts[1];
    string meal = commandParts[2];

    if (action == "Like")
    {
        if (!guests.ContainsKey(guestName))
        {
            guests[guestName] = new List<string>();
            guests[guestName].Add(meal);
        }
        else
        {
            if (!guests[guestName].Contains(meal))
            {
                guests[guestName].Add(meal);
            }
        }
    }
    else if (action == "Dislike")
    {
        if (!guests.ContainsKey(guestName))
        {
            Console.WriteLine($"{guestName} is not at the party.");
        }
        else
        {
            if (!guests[guestName].Contains(meal))
            {
                Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
            }
            else
            {
                guests[guestName].Remove(meal);
                dislikedMealsCount++;
                Console.WriteLine($"{guestName} doesn't like the {meal}.");
            }
        }
    }
}

foreach (var kvp in guests)
{
    Console.Write($"{kvp.Key}: ");
    Console.WriteLine(string.Join(", ", kvp.Value));
}

Console.WriteLine("Unliked meals: " + dislikedMealsCount);