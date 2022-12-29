int[,] GetArr2(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArr2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int MinSumStr(int[,] arr, int stolb, int max)
{
    int stroka = 0;
    int curSum = 0;
    int minSum = stolb * max;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            curSum = curSum + arr[i, j];
        }
        if (curSum < minSum)
        {
            minSum = curSum;
            stroka = i + 1;
        }
        curSum = 0;
    }
    return stroka;
}
int[,] array = GetArr2(4, 4, 1, 20);
PrintArr2(array);
Console.WriteLine($"Cтрока с минимальной суммой: {MinSumStr(array, 4, 20)}");