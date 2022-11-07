// Задача 27: Напишите программу, которая
// 1: принимает на вход число
// 2: выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummDigit(int n)
{
    int summ = 0;
    if (n < 0) n *= -1;
    while (n!= 0)
    {
        summ += n % 10;
        n /= 10;
    }
    return summ;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


int summDigit = SummDigit(a);
Console.WriteLine($"Сумма цифр в числе {a} = {summDigit}");