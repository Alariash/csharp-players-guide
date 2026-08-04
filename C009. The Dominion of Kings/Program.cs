Console.Write("Your estates: ");
int estates = Convert.ToInt32(Console.ReadLine());
Console.Write("Your duchies: ");
int duchies = Convert.ToInt32(Console.ReadLine());
Console.Write("Your provinces: ");
int provinces = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You have {estates*1+duchies*3+provinces*6}");