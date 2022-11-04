// 12. Напишите программу, которая будет
// принимать на вход два числа и выводить
// 1: является ли 1 число кратным 2
// 2: Если число 1 не кратно числу 2, то
// программа выводит остаток

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int MultipleNumber(int firstnumber, int secondnumber)
{
    int result = firstnumber % secondnumber;
    return result;
}

Console.Write("Введите целое число №1: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число №2: ");

int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.Write("Данные числа не удовлетворяют условиям задачи.");
    Console.Write("Число №1 должно быть больше числа №2.");
}
else
{
    int rest = MultipleNumber(a, b);
    Console.WriteLine(rest == 0 ? "Кратно" : $"Не кратно, остаток {rest}");
}


