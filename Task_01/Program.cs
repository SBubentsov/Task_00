﻿// 1. Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите целое число №1: ");

int square = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число №2: ");

int num = Convert.ToInt32(Console.ReadLine());

if (square = num * num)
    {
        Console.WriteLine("Да");
    }
Console.WriteLine("Нет");