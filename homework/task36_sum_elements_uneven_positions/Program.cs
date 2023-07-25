// create random array
// find sum of uneven elements

int[] array = new int[new Random().Next(10, 100)];
int sum = array[0];

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void SumUneven()
{
    for (int i = 0; i < array.Length; i++)
    {
        if ((i+1) % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine(sum);
}

Console.WriteLine("");
FillArray();
Console.WriteLine("");
PrintArray();
Console.WriteLine("");
SumUneven();
Console.WriteLine("");