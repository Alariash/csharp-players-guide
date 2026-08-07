ChestState state = ChestState.Locked;
string command;

while (true)
{
    switch (state)
    {
        case ChestState.Locked: 
            Console.Write($"The chest is locked. What do you want to do? ");
            break;
        case ChestState.Closed:
            Console.Write($"The chest is unlocked. What do you want to do? ");
            break;
        case ChestState.Open:
            Console.Write($"The chest is open. What do you want to do? ");
            break;           
    }
    
    command = Console.ReadLine();

    if (command == "unlock" && state == ChestState.Locked)
        state = ChestState.Closed;
    else if (command == "open" && state == ChestState.Closed)
        state = ChestState.Open;
    else if (command == "close" && state == ChestState.Open)
        state = ChestState.Closed;
    else if (command == "lock" && state == ChestState.Closed)
        state = ChestState.Locked;
}
    
enum ChestState {Locked, Closed, Open};

