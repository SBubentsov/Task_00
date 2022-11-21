// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат
// (число умноженное на само себя). 

// Например: 
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
// подсказка для пользователя (что от него требуется)

int num = Convert.ToInt32(Console.ReadLine());
// ввод данных пользователем

// string str = Console.ReadLine();
// int n = Convert.ToInt32(str);

int square = num * num;
// вычисления

Console.WriteLine($"Квадрат числа {num} = {square}");
// вывод с подсказкой для пользователя

// void PrintArray(int[,] matr)  // метод вывода на печать двумерного массива
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j]} | ");
//             else Console.Write($"{matr[i, j]}");
//         }
//         Console.WriteLine(" ]");
//     }
// }

void FillArray(int[,] matr, int min, int max) // метод заполнения двумерного массива псевдослучайными числами
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }

    }
}



// int minArray = 0; // минимальное значение в массиве
// int maxArray = 10; // максимальное значение в массиве

// int a = 3;  // количество строк
// int b = 5;  // количество столбцов
// int[,] matrix = new int[a, b];

// PrintArray(matrix);
// FillArray(matrix, minArray, maxArray);
// Console.WriteLine();
// PrintArray(matrix);