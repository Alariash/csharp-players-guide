int estates = AskForNumber("Your estates: ");
int duchies = AskForNumber("Your duchies: ");
int provinces = AskForNumber("Your provinces: ");
Console.WriteLine($"You have {estates*1+duchies*3+provinces*6} points.");

int AskForNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}