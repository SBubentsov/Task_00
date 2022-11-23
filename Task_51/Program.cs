// 51. Задайте двумерный массив.
// найдите сумму элементов находящихся на главной диагонали.
//  0.0 1.1 и т.д.

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

int SummMainDiagMatrix(int[,] matrix)
{
    int count = default;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
      count += matrix[i,i];
    }
    return count;
}

Console.WriteLine("Введите количество строк массива");
int newrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int newcolumns = Convert.ToInt32(Console.ReadLine());
int minimum = -9;
int maximum = 8;

int[,] newmatrix = CreateMatrixRndInt(newrows, newcolumns, minimum, maximum);

PrintMatrix(newmatrix);
Console.WriteLine($"Сумма элементов на главной диагонали равна {SummMainDiagMatrix(newmatrix)}");
