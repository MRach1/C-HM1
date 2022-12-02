int numb = int.Parse(Console.ReadLine()!);
string answ = "";
if(numb < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    answ = numb.ToString();
    Console.WriteLine(answ[2]);
}
