// find product from pairs of numbers
// regard as pair: first & last, second & prelast etc.

int[] array = new int[new Random().Next(5, 11)];

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void Multiplication()
{
    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            //   int multi = array[i] * array[array.Length-i];
            Console.Write($"{array[i] * array[array.Length - 1 - i]}, ");
        }
    }
    else 
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            //   int multi = array[i] * array[array.Length-i];
            Console.Write($"{array[i] * array[array.Length - 1 - i]}, ");
        }
        Console.Write(array[array.Length/2]);
    }

}

FillArray();
Console.WriteLine("");
PrintArray();
Console.WriteLine("");
Multiplication();
Console.WriteLine("");
