﻿// Задача 10: Напишите программу, которая
// 1: принимает на вход трёхзначное число
// 2: на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456-> 5
// 782-> 8
// 918-> 1

int SecondDigit(int number)
{
    int firststep = number / 10;
    return firststep % 10;
}


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000 || a > -1000 && a < -99)
{
    if (a > -1000 && a < -99) a = a * -1;
    Console.Write(SecondDigit(a));
}
else
{
    Console.Write("Данное число не удовлетворяет условия задачи.");
}