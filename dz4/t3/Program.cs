int[] mass = new int[8];
Console.Write("Введите количество чисел в массиве (от 0 до 8): ");
int n = int.Parse(Console.ReadLine()!);
void fun(int a)
{
    int q = 0;
    while(q < a)
    {
        Console.Write($"Введите {q + 1} число массива: ");
        mass[q] = int.Parse(Console.ReadLine()!);
        q++;
    }
    q = 0;
    while (q < a)
    {
        Console.Write($"{mass[q]} ");
        q++;
    }
}
fun(n);