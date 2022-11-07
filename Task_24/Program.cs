// Задача 24: Напишите программу, которая
// 1: принимает на вход число (А)
// 2:выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Write("Введите число больше 1: ");

int a = Convert.ToInt32(Console.ReadLine());

int Summ(int n)
{
    int summ = 0;
   
    for (int i = 1; i <= n; i++)
    {
        summ += i;
    }
 return summ;
}

if (a > 0)
{
    int allsumm = Summ(a);
    Console.WriteLine($"Сумма чисел от 1 до {a}: {allsumm}");
}
else Console.WriteLine("Введено некорректное число, требуется целое положительное число.");
