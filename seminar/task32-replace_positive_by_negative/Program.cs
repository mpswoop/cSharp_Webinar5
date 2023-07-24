// create array
// replace positive by negative and way round

int[] array = new int[12];

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ,");
    }

    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] * -1} ,");
    }
}

FillArray();
PrintArray();

Console.WriteLine();