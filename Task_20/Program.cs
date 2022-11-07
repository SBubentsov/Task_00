// 20. Напишите программу, которая
// 1: принимает координаты двух точек
// 2: находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты точки A.");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B.");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

// double l = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb));
// double lenght = Math.Round(l, 2, MidpointRounding.ToZero);
// Console.WriteLine($"Длинна отрезка по заданным точкам: {lenght}");


double l = Math.Sqrt( Square(xa, xb) + Square(ya, yb));
double lenght = Math.Round(l, 2, MidpointRounding.ToZero);
Console.WriteLine($"Длинна отрезка по заданным точкам: {lenght}");

int Square(int num1, int num2)
{
    return (num1 - num2) * (num1 - num2);
}