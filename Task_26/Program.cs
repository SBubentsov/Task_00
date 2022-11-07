// Задача 26: Напишите программу, которая
// 1: принимает на вход число
// 2: выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Count(int n)
{
    int count = 0;
    
    while (n!= 0)
    {
        n /= 10;
        count++;
    }
    return count > 0 ? count : 1;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


int allcount = Count(a);
Console.WriteLine($"Количество цифр в числе {a}: {allcount}");

