int AskForNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int AskForNumberInRange(string text, int min, int max)
{
    int number;
    
    while (true)
    {
        Console.Write(text);
        number = Convert.ToInt32(Console.ReadLine());
        if (number >= min && number <= max) return number;
    }
}

int number = AskForNumber("What's the air speed of a fully laden batman? ");
Console.WriteLine($"Your answer: {number}");

int number2 = AskForNumberInRange("Name a number between 10 and 100: ", 10, 100);
Console.WriteLine($"Your answer: {number2}");
