// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

void NumGlossariumMatrix(int[,] matrix, int min, int max)
{
    int num = 0;
    

    while (num < max + 1)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)

        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (num == matrix[i, j]) count++;
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"Число {num} встречается в массиве {count} раз");
            num++;
        }
        else num ++;
    }

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
NumGlossariumMatrix(newmatrix, minimum, maximum);