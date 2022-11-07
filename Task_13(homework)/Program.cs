// Задача 13: Напишите программу, которая
// 1: выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int TherdDigit(int number)
{
    while (number > 999) number = number / 10;
    return number % 10;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 || a < -99)
{
    if (a < -99) a = a * -1;

        Console.Write(TherdDigit(a));
}


else
{
    Console.Write("Третьей цифры нет.");
}