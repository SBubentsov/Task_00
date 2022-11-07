// Задача 25: Напишите цикл, который
// 1: принимает на вход два числа (A и B)
// 2: возводит число A в натуральную степень B. (реализовал возможность возведения в отрицательную степень)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


double Extent(int n1, int n2)
{
    double extent = 1;
    if (n2 >= 0)
    {
        for (int i = 1; i <= n2; i++)
        {
            extent *= n1;
        }
        return extent;
    }
    else
    {
        for (int i = -1; i >= n2; i--)
        {
            extent /= n1;
        }
        return extent;
    }
}
Console.Write("Введите число A: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");

int b = Convert.ToInt32(Console.ReadLine());

if (a != 0)
{
    double ext = Extent(a, b);
    double exten = Math.Round(ext, 10, MidpointRounding.AwayFromZero);
    Console.WriteLine($"Число {a} в степени {b} = {exten}");
}
else Console.WriteLine("0 в любой степени будет 0");