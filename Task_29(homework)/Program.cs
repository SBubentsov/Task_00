// Задача 29: Напишите программу, которая
// 1: задаёт массив из 8 элементов (количество элементов в массиве вводит пользователь)
// 2: выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(" | ");
    }
    Console.WriteLine(" ]");
}

Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a > 0)
{
    int[] arr = CreateArray(a);
    PrintArray(arr);
}
else Console.WriteLine("Введено некорректное число, требуется целое положительное число.");