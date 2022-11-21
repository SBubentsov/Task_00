// Задача 43: Напишите программу, которая
// найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double CoordinatesX(double a1, double a2, double c1, double c2)
{
    double coordinatesX = (c2-c1)/(a1-a2);
    return coordinatesX;
}

double CoordinatesY(double coordinatesX, double a1, double c1)
{
    double coordinatesY = a1*coordinatesX+c1;
    return coordinatesY;
}


Console.WriteLine("Для уравнений y = k1 * x + b1, y = k2 * x + b2 поочереди введите значения переменных: ");

Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают.");
}
else if(k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые не пересекаются.");
}
else
{
    double coordinsX = CoordinatesX(k1, k2, b1, b2);
    double coordinsY = CoordinatesY(coordinsX, k1, b1);

    Console.WriteLine($"Координаты точки пересечения прямых : ({coordinsX}; {coordinsY})");
}