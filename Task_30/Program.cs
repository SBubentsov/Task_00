// Задача 30: Напишите программу, которая
// 1: выводит массив из N элементов, заполненный
// 2: нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray(int size)
{
    int[] array = new int[size];
   
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
 return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i<array.Length-1) Console.Write(" | ");
    }
    Console.WriteLine(" ]");
}

Console.Write("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a > 0)
{
 int[] arr= CreateArray(a);
 PrintArray(arr);
}
else Console.WriteLine("Введено некорректное число, требуется целое положительное число.");