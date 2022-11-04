// 16. Написать программу, которая
// 1: принимает на вход два числа
// 2: проверят, явлется ли одно число квадратом второго

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

bool Square(int num1, int num2)
{
    return num2*num2 == num1 || num1*num1 == num2;
}

Console.Write("Введите число №1: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");

int b = Convert.ToInt32(Console.ReadLine());

bool square = Square(a, b);

Console.Write(square ? "да" : "нет");