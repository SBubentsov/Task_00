// Задача 34: Задайте массив
// 1: заполненный случайными положительными трёхзначными числами.
// 2: Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} | ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(" ]");
}

int HonestNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] % 2 == 0 ) count ++;
    }
    return count;
}


Console.WriteLine("Введите размер массива");
int leng = Convert.ToInt32(Console.ReadLine());
int minimum = 100;
int maximum = 1000;

int[] arr = CreateArrayRndInt(leng, minimum, maximum);
PrintArray(arr);
int result = HonestNumber(arr);

Console.WriteLine($"Количество четных чисел в массиве -> {result}");
