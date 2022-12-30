int Ack(int m, int n)
{   
    if (m >= 0 & n >= 0)
    {
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 & n == 0)
    {
        return Ack(m - 1, 1);
    }
    if(m > 0 & n > 0)
    {
        return Ack(m - 1, Ack(m, n -1));
    }
    }
    else
    {
        return 0;
    }
    return(Ack(m, n));
}
Console.Write("M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("N = ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Ack(M, N));