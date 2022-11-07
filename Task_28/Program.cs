// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



Console.Write("Введите число больше 1: ");

int a = Convert.ToInt32(Console.ReadLine());

int Multiplication(int n)
{
    int mult = 1;
   
    for (int i = 1; i <= n; i++)
    {
        mult *= i;
    }
 return mult;
}

if (a > 0)
{
    int multiplication = Multiplication(a);
    Console.WriteLine($"Произведение чисел от 1 до {a}: {multiplication}");
}
else Console.WriteLine("Введено некорректное число, требуется целое положительное число.");