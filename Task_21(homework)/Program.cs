// 21. Напишите программу, которая 
// 1: принимает на вход координаты двух точек
// 2: находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A.");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B.");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zb = Convert.ToInt32(Console.ReadLine());



double distance = Math.Sqrt( Square(xa, xb) + Square(ya, yb) + Square(za, zb));
double length = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Длинна отрезка по заданным точкам: {length}");

int Square(int num1, int num2)
{
    return (num1 - num2) * (num1 - num2);
}