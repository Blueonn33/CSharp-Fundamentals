using System.Text.RegularExpressions;

int lines = int.Parse(Console.ReadLine());
string patternForCount = @"[STARstar]";
string patternForMessage = @"@(?<planet>[A-Za-z]+)[^@\-!>]*:(?<population>[0-9]+)[^@\-!>]*!(?<action>[A-Z])![^@\-!>]*->(?<soldiers>[0-9]+)";

List<string> attackedPlanets = new List<string>();
List<string> destroyedPlanets = new List<string>();

for (int i = 0; i < lines; i++)
{
    string encryptedMessage = Console.ReadLine();
    string decryptedMessage = string.Empty;

    MatchCollection matchForCount = Regex.Matches(encryptedMessage, patternForCount);
    int count = matchForCount.Count;

    for (int j = 0; j < encryptedMessage.Length; j++)
    {
        char decryptedChar = (char)(encryptedMessage[j] - count);
        decryptedMessage += decryptedChar;
    }

    Match matchForMessage = Regex.Match(decryptedMessage, patternForMessage);

    if (matchForMessage.Success)
    {
        string planet = matchForMessage.Groups["planet"].Value;
        string action = matchForMessage.Groups["action"].Value;

        if (action == "A")
        {
            attackedPlanets.Add(planet);
        }
        else if (action == "D")
        {
            destroyedPlanets.Add(planet);
        }
    }
}

Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
attackedPlanets.Sort();

foreach (var planet in attackedPlanets)
{
    Console.WriteLine($"-> {planet}");
}

Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
destroyedPlanets.Sort();

foreach (var planet in destroyedPlanets)
{
    Console.WriteLine($"-> {planet}");
}