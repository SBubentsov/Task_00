// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


long AkkermanFunction(long num1, long num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0)
    {
        return AkkermanFunction(num1 - 1, 1);
    }
    else return AkkermanFunction(num1 -1, AkkermanFunction(num1, num2 - 1));
}

Console.Clear();
Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

if (m>=0 && n>=0)
{
long summ = AkkermanFunction(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке [{m};{n}]={summ}");
}
else
{
    Console.WriteLine("Введены некорректные значения.");
}