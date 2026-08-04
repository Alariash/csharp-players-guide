int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

int currentSmallest = int.MaxValue;
foreach (var number in array)
{
    if (number < currentSmallest)
        currentSmallest = number;
}

Console.WriteLine(currentSmallest);