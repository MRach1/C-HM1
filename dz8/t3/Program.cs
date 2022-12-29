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
int[,] Multiply(int[,] A, int[,] B)
{
    int[,] res = new int[A.GetLength(0), B.GetLength(1)];
    for (int zi = 0; zi < res.GetLength(0); zi++)
    {
        for (int zj = 0; zj < res.GetLength(1); zj++)
        {
            for (int k = 0; k < res.GetLength(0); k++)
            {
                res[zi, zj] = res[zi, zj] + (A[zi, k] * B[k, zj]);
            }
        }
    }
    return res;
}
int[,] arr1 = GetArr2(2, 2, 1, 5);
int[,] arr2 = GetArr2(2, 2, 1, 5);
PrintArr2(arr1);
Console.WriteLine();
PrintArr2(arr2);
Console.WriteLine();
int[,] arr3 = Multiply(arr1, arr2);
PrintArr2(arr3);