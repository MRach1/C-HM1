int N = int.Parse(Console.ReadLine()!);
void Re(int n)
{
    if (n > 0)
    {
        if (n != 1)
        {
            Console.Write($"{n}, ");
            Re(n-1);
        }
        else
        {
            Console.Write(n);
        }
    }
}
Re(N);