// Найти произведение двух матриц

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число столбцов");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] firstMatrix = FillMatrix(m, n);
int[,] secondMatrix = FillMatrix(m, n);

Console.WriteLine($"Первая матрица ");
PrintMatrix(firstMatrix);
Console.WriteLine($"Вторая матрица ");
PrintMatrix(secondMatrix);
Console.WriteLine($"Произведение первой и второй матрицы ");

int[,] sumMatrix = sumMatrix = new int[m, n];
for (int i = 0; i < sumMatrix.GetLength(0); i++)
{
    for (int j = 0; j < sumMatrix.GetLength(1); j++)
    {
        sumMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
    };
}

PrintMatrix(sumMatrix);