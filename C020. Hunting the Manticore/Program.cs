// Initialize the game ---------------------------------------------------------------------------------------------------------------
int round = 0;
int cityHealth = 15;
int manticoreHealth = 10;
int manticorePosition = -1;
int cannonRange = -1;
int cannonDamage = 0;

// Start the game ----------------------------------------------------------------------------------------------------------------------------
manticorePosition = GetDesiredPosition("Player 1, how far away from the city do you want to station the Manticore? ", 0, 100);
Console.Clear();

while (true)
{
    round++;
    cannonDamage = GetCannonDamage(round);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
    
    // Try to hit the manticore
    cannonRange = GetRange("Enter desired cannon range: ");
    if(IsTargetHit(cannonRange, manticorePosition)) manticoreHealth -= GetCannonDamage(round);

    if (manticoreHealth < 0) break;

    // Damage the city
    if (cityHealth > 0) cityHealth--;
    else break;
}

// End the game
Console.WriteLine(manticoreHealth<0 ? "The Manticore has been destroyed! The city of Consolas has been saved!" : "The city of Consolas has been destroyed!");
// Redo, give colors
if (manticoreHealth <= 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The city of Consolas has been lost!");
}
    

// Functions -------------------------------------------------------------------------------------------------------------------------------
int GetRange(string message)
{
    Console.Write(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int GetDesiredPosition(string message, int min, int max)
{
    int x = int.MaxValue;
    Console.Write(message);
    while(x < min || x > max)
        x = Convert.ToInt32(Console.ReadLine());
    
    return x;
}

int GetCannonDamage(int round)
{
    if (round % 5 == 0 && round % 3 == 0)
        return 10;
    else if (round % 5 == 0 || round % 3 == 0)
        return 3;
    else
        return 1;
}

bool IsTargetHit(int range, int target)
{
    if (range == target)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("That round was a DIRECT HIT!");
        return true;
    }
    if (range < target)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else if (range > target)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That round OVERSHOT the target.");
    }

    return false;
}