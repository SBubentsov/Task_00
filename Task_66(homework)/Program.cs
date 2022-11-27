// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SummNaturalNambers(int num1, int num2)
{
    if (num1 > 0 && num1 > num2)
    {
        return num1 += SummNaturalNambers(num1 - 1, num2);
    }
    else if (num2 > 0 && num2 > num1)
    {
        return num2 += SummNaturalNambers(num2 - 1, num1);
    }
    else return num1;
}

Console.Clear();
Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());


int summ = SummNaturalNambers(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке [{m};{n}]={summ}");