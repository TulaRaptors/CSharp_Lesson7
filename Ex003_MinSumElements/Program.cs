// В прямоугольной матрице найти строку с наименьшей суммой элементов.


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

int MinRowAmount(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum[i] += matrix[i, j];
    int minimum = sum[0];
    int number = 0;
    for (int i = 1; i < sum.Length; i++)
        if (sum[i] < minimum)
        {
            minimum = sum[i];
            number = i;
        }
    return number;
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
Console.WriteLine();
int number = MinRowAmount(matrix);
Console.WriteLine($"Минимальная сумма элементов у {number + 1}-й строки");