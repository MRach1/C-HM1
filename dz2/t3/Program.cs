Console.WriteLine("Введите число от 1 до 7");
int numb = int.Parse(Console.ReadLine()!);
if (numb > 7 || numb < 1)
{
    Console.WriteLine("Вы ввели неправильное число.");
}
else
{
    if(numb == 6 || numb == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Не выходной");
    }
}