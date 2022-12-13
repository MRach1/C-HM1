Console.Write("Количество чисел: ");
int consoleSize = int.Parse(Console.ReadLine()!);
double[] array = new double[consoleSize];
double[] MakeArray(int sizz)
{
    int q = 0;
    double[] res = new double[sizz];
    while(q < sizz)
    {
        Console.Write($"Введите {q + 1} число массива: ");
        res[q] = Convert.ToDouble(Console.ReadLine());
        q++;
    }
    return res;
}
double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 101);
    }
    return result;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine("Заполнить массив случайными числами или вручную? Для заполнения случайными числами введите '0'. Для самостоятельного заполнения введите '1'" );

Console.WriteLine("");
int answer = int.Parse(Console.ReadLine()!);
if(answer == 0) 
{
    array = GetArray(consoleSize);
}
else 
{
    array = MakeArray(consoleSize);
}
PrintArray(array);
double Max(double[] arr)
{
    double maximum = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maximum) maximum = arr[i];
    }
    return maximum;
}
double Min(double[] arr)
{
    double minimum = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minimum) minimum = arr[i];
    }
    return minimum;
}
Console.WriteLine();
Console.WriteLine($"Разность максимального и минимального равна {Max(array) - Min(array)}");