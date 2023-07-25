// create random array
// find difference between min and max

double[] array = new double[new Random().Next(5, 8)];
double max = array[0];
double min = 1000;

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100) + new Random(2).NextDouble();
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void MinMax()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine(min);
    Console.WriteLine(max);
    Console.WriteLine(max - min);
}

Console.WriteLine("");
FillArray();
Console.WriteLine("");
PrintArray();
Console.WriteLine("");
MinMax();
Console.WriteLine("");