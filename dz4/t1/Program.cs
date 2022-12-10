int n1 = int.Parse(Console.ReadLine()!);
int n2 = int.Parse(Console.ReadLine()!);
double fun(int a, int b)
{
    return Math.Pow(a, b);
}
Console.WriteLine(fun(n1, n2));