var price = 0;
string item = "";
Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");
var choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        item = "Rope";
        price = 10;
        break;
    case 2:
        item = "Torches";
        price = 15;
        break;
    case 3:
        item = "Climbing Equipment";
        price = 25;
        break;
    case 4:
        item = "Clean Water";
        price = 1;
        break;
    case 5:
        item = "Machete";
        price = 20;
        break;
    case 6:
        item = "Canoe";
        price = 200;
        break;
    case 7:
        item = "Food Supplies";
        price = 1;
        break;
    default:
        item = "";
        price = 0;
        break;
}

if (choice > 0 && choice <= 7)
{
    Console.WriteLine($"{item} cost {price} gold.");
}
else
{
    Console.WriteLine("We do not sell that.");
}