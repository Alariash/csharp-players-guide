(Type foodType, MainIngredient foodIngredient, Seasoning foodSeasoning) dish;

Console.WriteLine("What would you like to eat?");
Console.WriteLine("1 - soup");
Console.WriteLine("2 - stew");
Console.WriteLine("3 - gumbo");
dish.foodType = (Type)int.Parse(Console.ReadLine());

Console.WriteLine("What should be the main ingredient?");
Console.WriteLine("1 - mushrooms");
Console.WriteLine("2 - chicken");
Console.WriteLine("3 - carrots");
Console.WriteLine("4 - potatoes");
dish.foodIngredient = (MainIngredient)int.Parse(Console.ReadLine());

Console.WriteLine("What do we season it with?");
Console.WriteLine("1 - spice");
Console.WriteLine("2 - salt");
Console.WriteLine("3 - sweetness");
dish.foodSeasoning = (Seasoning)int.Parse(Console.ReadLine());

Console.WriteLine($"{dish.foodSeasoning} {dish.foodIngredient} {dish.foodType}");


enum Type {Soup = 1, Stew = 2, Gumbo = 3};
enum MainIngredient {Mushrooms = 1, Chicken = 2, Carrots = 3, Potatoes = 4};
enum Seasoning {Spicy = 1, Salty = 2, Sweet = 3};