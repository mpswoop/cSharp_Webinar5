// array of random positive 3-digit numbers
// amount of even numbers in array

int[] array = new int[new Random().Next(1, 100)];
int count = 0;

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void CountEven()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine(count);
}

Console.WriteLine("");
FillArray();
Console.WriteLine("");
PrintArray();
Console.WriteLine("");
CountEven();
Console.WriteLine("");