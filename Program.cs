Console.Write("Введите координаты X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Z2: ");
int z2 = int.Parse(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double dlina = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расчетная длинна отрезка {dlina}");


