// create array of 12 random elements betewwn -9 & 9
// find sum of each positive and negative numbers

// int[] array = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
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
        Console.Write($"{array[i]}, ");
    }
}

void CalculateSums()
{
    int sum_negative = 0;
    int sum_positive = 0;

    for (int i = 0; i < 12; i++)
    {



        if (array[i] < 0)
        {
            sum_negative = sum_negative - array[i];
        }
        else if (array[i] > 0)
        {
            sum_positive = sum_positive + array[i];
        }

    }
    Console.WriteLine($" Positive Sum: {sum_positive}");
    Console.WriteLine($" Negative Sum: {sum_negative*-1}");
}

FillArray();
PrintArray();
Console.WriteLine("");
CalculateSums();
Console.WriteLine("");