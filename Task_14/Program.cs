// 14. Написать программу, которая
// 1: принимает на вход число
// 2: проверяет, кратно ли оно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

int MultipleNumber(int number)
{
    return number % (7 * 23);
}

Console.Write("Введите целое число: ");

int a = Convert.ToInt32(Console.ReadLine());

int rest = MultipleNumber(a);
Console.WriteLine(rest == 0 ? "Кратно" : $"Не кратно, остаток {rest}");