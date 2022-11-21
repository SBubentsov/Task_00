// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write(". ");
}

int CountPositiveDigit(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) summ++;
    return summ;
}


Console.Write("Сколько чисел вы хотите ввести? ");
int m = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(m);
PrintArray(arr);

Console.WriteLine($"Количество чисел больше нуля -> {CountPositiveDigit(arr)}");


