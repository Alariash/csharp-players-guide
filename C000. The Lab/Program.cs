int number = 0;

Console.WriteLine($"Number before modification, in main: {number}");
ChangeNumber();
Console.WriteLine($"Number after modification, in main: {number}");

void ChangeNumber()
{
    Console.WriteLine($"Number before modification, inside function: {number}");
    number = 50;
    Console.WriteLine($"Number after modification, inside function: {number}");
}

