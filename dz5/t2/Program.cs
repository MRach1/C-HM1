Console.Write("Количество чисел: ");
int consoleSize = int.Parse(Console.ReadLine()!);
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int summ = 0;
int[] array = GetArray(consoleSize);
PrintArray(array);
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 0) 
    {
        summ += array[j];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечётных позициях равна {summ}");
