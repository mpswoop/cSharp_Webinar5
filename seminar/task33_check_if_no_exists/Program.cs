// create array, check if given no is inside random array

Console.WriteLine("Please input number");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[4];
string answer = "no";

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        answer = "yes";
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();
Console.WriteLine(answer);
