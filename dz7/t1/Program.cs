Console.Clear();
double[,] GetArr2(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Random x = new Random();
            result[i, j] = Convert.ToDouble(x.Next(min * 10, max * 10) / 10.0);
        }
    }
    return result;
}

void PrintArr2(double[,] arr)
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
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArr2(rows, columns, 0, 100);
PrintArr2(array);
