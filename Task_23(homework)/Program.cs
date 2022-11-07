// 23. Напишите программу, которая 
// 1: принимает на вход число (N)
// 2: выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Table(int n)
{
    int count = 1;
    Console.WriteLine($"Таблица кубов чисел от 1 до {n} ->");
    while (count <= n)
    {

        Console.WriteLine($"{count,10} | {count * count * count,10}");
        count += 1;
    }
}

Console.Write("Введите число больше 1: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a > 0) Table(a);
else Console.WriteLine("Недопустимое число");