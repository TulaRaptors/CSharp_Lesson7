// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void FillMatrix(int[,] matrix, int minimum, int maximum)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = random.Next(minimum, maximum);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

void SortRowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 1; k < matrix.GetLength(1); k++)
            for (int j = 0; j < matrix.GetLength(1) - k; j++)
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[rows, columns];
FillMatrix(matrix, 1, 10);
Console.WriteLine("Ваша матрица: ");
PrintMatrix(matrix);
SortRowMatrix(matrix);
Console.WriteLine("Упорядоченная матрица: ");
PrintMatrix(matrix);