int[] array1 = new int[5];
int[] array2 = new int[5];

Console.WriteLine("Provide five numbers:");
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"{i}: ");
    array1[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
}

// Display Results
Console.WriteLine("First Array:");
for (int i = 0; i < array1.Length; i++)
{
    Console.Write($"{array1[i]} ");
}
Console.WriteLine("\nSecond Array:");
for (int i = 0; i < array2.Length; i++)
{
    Console.Write($"{array2[i]} ");
}