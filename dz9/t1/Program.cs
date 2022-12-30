int N = int.Parse(Console.ReadLine()!);
void Re(int n)
{
    if (n > 0)
    {
    Console.Write($"{n}, ");
    Re(n-1);
    }
}
Re(N);