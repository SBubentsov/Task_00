// Задача 22: Напишите программу, которая
// 1: на вход принимает число (N), 
// 2: выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

void Table(int n)
{
    if (n > 0)
    {
        int count = 1;
        Console.WriteLine("Все квадраты чисел от 1 до указанного числа:");
        while (count <= n)
        {

            Console.WriteLine($"{count} | {count * count}");
            count += 1;
        }
    }
    else Console.WriteLine("Недопустимое число");
}


Console.Write("Введите число больше 1: ");

int a = Convert.ToInt32(Console.ReadLine());

// if ( a < 2 )

//     Console.WriteLine("Недопустимое число");
// else
// {
//     int count = 2;
//     Console.Write("Все квадраты чисел от 1 до указанного числа: 1 ");
//     while (count <= a)
//     {

//         Console.Write($", {count*count}");
//         count += 1;
//     }
// }    

Table(a);