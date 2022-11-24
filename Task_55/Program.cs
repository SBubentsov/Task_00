// Задача 55: Задайте двумерный массив. Напишите программу, которая
//  заменяет строки на столбцы. 
//  В случае, если это невозможно, программа должна
//   вывести сообщение для пользователя.


Console.Clear();

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

int[,] CreateMatrixDiagRevers(int[,] matrix)
{
    int[,] reversmatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];


    for (int i = 0; i < reversmatrix.GetLength(0); i++)

    {
        for (int j = 0; j < reversmatrix.GetLength(1); j++)
        {
            reversmatrix[i, j] = matrix[j, i];
        }
    }
    return reversmatrix;
}

Console.WriteLine("Введите количество строк массива");
int newrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int newcolumns = Convert.ToInt32(Console.ReadLine());
int minimum = 1;
int maximum = 10;

int[,] newmatrix = CreateMatrixRndInt(newrows, newcolumns, minimum, maximum);

PrintMatrix(newmatrix);
Console.WriteLine();
int[,] matrixdiagrevers = CreateMatrixDiagRevers(newmatrix);
PrintMatrix(matrixdiagrevers);