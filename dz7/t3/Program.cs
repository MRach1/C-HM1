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
double AverageCol(int[,] arr, int stl)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i, stl];
    }
    return (sum / Convert.ToDouble(arr.GetLength(0)));
}
int[,] array = GetArr2(6, 5, 0, 20);
PrintArr2(array);
Console.WriteLine();
for (int s = 0; s < array.GetLength(1); s++)
{
    Console.Write($"{AverageCol(array, s)} ");
}