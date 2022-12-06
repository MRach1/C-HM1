Console.WriteLine("Координаты первой точки");
Console.Write("X: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Y: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Z: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Координаты второй точки");
Console.Write("X: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Y: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Z: ");
int z2 = int.Parse(Console.ReadLine()!);

double xlen = Math.Pow((x2 - x1), 2);
double ylen = Math.Pow((y2 - y1), 2);
double zlen = Math.Pow((z2 - z1), 2);
double answ = Math.Sqrt(xlen + ylen + zlen);
Console.WriteLine(Math.Round(answ, 2));
