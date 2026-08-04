Console.WriteLine("What kind of thing are we talking about?");
string itemName = Console.ReadLine(); // The item
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string itemDescription = Console.ReadLine(); /* The descriptor */
string type = "of Doom";
string model = "3000";
Console.WriteLine("The " + itemDescription + " " + itemName + " " + type + " " + model + "!");