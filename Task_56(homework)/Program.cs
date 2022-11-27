// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matr = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"| {matr[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}

int[] SumMatrixRows(int[,] matr)
{
    int[] sumMatrRows = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sumRows = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRows += matr[i,j];
        }
        sumMatrRows[i] = sumRows;
    }
    return sumMatrRows;
}


int MatrixMinSumRows(int[] sumMRows)
{
    int indexMinRows = 0;
    for (int i = 1; i < sumMRows.Length; i++)
    {
        if (sumMRows[i] < sumMRows[indexMinRows]) indexMinRows = i;
    }
    return indexMinRows+1;
}

Console.Clear();
Console.WriteLine("Введите количество строк массива");
int newrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int newcolumns = Convert.ToInt32(Console.ReadLine());
int minimum = -9;
int maximum = 8;
int[,] matrix = CreateMatrixRndInt( newrows, newcolumns, minimum, maximum);

Console.WriteLine();
PrintMatrix(matrix);

int[] sumMatrixRows = SumMatrixRows(matrix);

int matrixMinSumRows = MatrixMinSumRows(sumMatrixRows);

Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {matrixMinSumRows}.");