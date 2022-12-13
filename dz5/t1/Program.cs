Console.Write("Количество чисел: ");
int consoleSize = int.Parse(Console.ReadLine()!);
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
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
int summChet = 0;
int[] array = GetArray(consoleSize);
PrintArray(array);
foreach (int el in array)
{
    if (el % 2 == 0) summChet += el;
}
Console.WriteLine();
Console.WriteLine($"Сумма чётных равна {summChet}");
