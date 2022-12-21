
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
void GetElement2(int str, int stl, double[,] arr)
{
    if(str >= arr.GetLength(0) | stl >= arr.GetLength(1))
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        Console.WriteLine(arr[str, stl]);
    }
}
double[,] array = GetArr2(7, 7, 0, 100);
PrintArr2(array);

Console.Write("Индекс 1: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Индекс 2: ");
int column = int.Parse(Console.ReadLine()!);
GetElement2(row, column, array);