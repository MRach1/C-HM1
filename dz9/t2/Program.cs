Console.Write("M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("N = ");
int N = int.Parse(Console.ReadLine()!);
int SumMN(int m, int n)
{
    int c = 0;
    if(m <= n)
    {
        c = c + m + SumMN(m + 1, n);
    }
    return c;
}
Console.WriteLine(SumMN(M, N));