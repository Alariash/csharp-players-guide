Console.Write("How many eggs were collected today? ");
int eggs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Each of the sisters gets {eggs/4} eggs. The Duckbear shall feast on {eggs%4} remaining eggs.");
