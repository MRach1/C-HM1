int fun(int a)
{
    int c = 0;
    while (a > 0)
    {
        c = c + (a % 10);
        a = a / 10;
    }
    return c;
}
int numb = int.Parse(Console.ReadLine()!);
Console.WriteLine(fun(numb));