
Console.Write("Количество чисел: ");
int M = int.Parse(Console.ReadLine()!);
int count = 0;
for(int i = 0; i < M; i++)
{
    Console.Write($"{i + 1} число: ");
    int number = int.Parse(Console.ReadLine()!);
    if (number > 0)
    {
        count++;
    }
}
Console.Write(count);