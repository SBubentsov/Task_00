// Задача 8: Напишите программу, которая
// на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите число больше 1: ");

int a = Convert.ToInt32(Console.ReadLine());

if ( a < 2 )
  
    Console.WriteLine("Недопустимое число");
else
{
    int count = 2;
    Console.Write("Все четные числа от 1 до указанного числа: ");
    while (count <= a)
    {
        
        Console.Write($"{count}, ");
        count += 2;
    }
}    