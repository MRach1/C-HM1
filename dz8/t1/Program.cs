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
void FromMinToMax(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int d = 0; d + 1 < arr.GetLength(1); d++)
        {
            for (int j = 1; j < arr.GetLength(1); j++ )
            {
                if (arr[i, j] > arr[i, j - 1])
                {
                    int clone = arr[i, j];
                    arr[i, j] = arr[i, j - 1];
                    arr[i, j - 1] = clone;
                }
            }
        }
    }
}
int [,] array = GetArr2(4, 6, 1, 20);
PrintArr2(array);
Console.WriteLine();
FromMinToMax(array);
PrintArr2(array);