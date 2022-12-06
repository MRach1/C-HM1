int numb = int.Parse(Console.ReadLine()!);
int cln = numb;
string simv = numb.ToString();
int n = 0;
int n0 = 0;
while(cln > 0)
{
    cln = cln / 10;
    n++;
}
n--;
int F = 1;
while(n0 < n)
{
    if (simv[n0] != simv[n])
    {
        F = 0;
    }
    n0++;
    n--;
}
if (F == 1)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("НЕ палиндром");
}