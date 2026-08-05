int targetNumber = AskForNumberInRange("User 1, enter a number between 0 and 100: ", 0, 100);
Console.Clear();
Console.WriteLine("User 2, guess the number.");

while (true)
{
    Console.Write("What is your next guess? ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess == targetNumber)
    {
        Console.WriteLine("You guessed the number!");
        return;
    }
    else if(guess < targetNumber) Console.WriteLine($"{guess} is too low.");
    else if (guess > targetNumber) Console.WriteLine($"{guess} is too high.");
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text);
        int number = Convert.ToInt32(Console.ReadLine());
        if (number >= min && number <= max) return number;
    }
}