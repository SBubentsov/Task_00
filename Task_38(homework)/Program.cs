// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} | ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(" ]");
}

double MaxNumberArray(double[] array)
{
    double maxNumber = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        i++;
    }
    return maxNumber;
}

double MinNumberArray(double[] array)
{
    double minNumber = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (array[i] < minNumber) minNumber = array[i];
        i++;
    }
    return minNumber;
}
double DifferenceMaxMinNumberArray(double[] array)
{

    double difference = MaxNumberArray(array) - MinNumberArray(array);
    return difference;
}

Console.WriteLine("Введите размер массива");
int leng = Convert.ToInt32(Console.ReadLine());
int minimum = -10;
int maximum = 11;

double[] arr = CreateArrayRndDouble(leng, minimum, maximum);
PrintArray(arr);
double resultDiff = Math.Round(DifferenceMaxMinNumberArray(arr), 1, MidpointRounding.ToEven);

Console.WriteLine($"Разница между минимальным и максимальным значениями массива -> {resultDiff}");

