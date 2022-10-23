// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

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

int[,] ReplaceRowsWithColumns(int[,] matrix)
{
    int length = matrix.GetLength(0);
    int[,] array = new int[length,length];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            array[j,i] = matrix[i,j]; 
    return array;  
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
if (rows != columns)
    Console.WriteLine("Поменять местами строки со столбцами невозможно. Матрица не квадратная!");
else 
{
int[,] array = ReplaceRowsWithColumns(matrix);
Console.WriteLine("Новая матрица: ");
PrintMatrix(array);
}