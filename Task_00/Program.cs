﻿// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат
// (число умноженное на само себя). 

// Например: 
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
// подсказка для пользователя (что от него требуется)

int num = Convert.ToInt32(Console.ReadLine());
// ввод данных пользователем

// string str = Console.ReadLine();
// int n = Convert.ToInt32(str);

int square = num * num;
// вычисления

Console.WriteLine($"Квадрат числа {num} = {square}");
// вывод с подсказкой для пользователя
