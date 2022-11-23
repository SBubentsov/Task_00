// 49. Задайте двемерный массив размером m*n.
// Найдите элементы, у которых оба индекса четные
// и замените эти элементы на их квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {


            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {


            if (i%2==0 && j%2==0) matrix[i,j] *= matrix[i,j];
        }
    }
}

Console.WriteLine("Введите количество строк массива");
int newrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int newcolumns = Convert.ToInt32(Console.ReadLine());
int minimum = -9;
int maximum = 8;

int[,] newmatrix = CreateMatrixRndInt(newrows, newcolumns, minimum, maximum);

PrintMatrix(newmatrix);
Console.WriteLine();
ChangeMatrix(newmatrix);

PrintMatrix(newmatrix);