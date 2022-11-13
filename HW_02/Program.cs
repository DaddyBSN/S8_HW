// В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
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

Console.WriteLine("Введите число строк:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число столбцов:");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

int min = matrix[0, 0];
int iMin = 0;
int jMin = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            iMin = i;
            jMin = j;
        }
    }
}

Console.WriteLine("Наименьший элемент:");
Console.WriteLine(min);
Console.WriteLine("Строка:");
Console.WriteLine(iMin + 1);
Console.WriteLine("Столбец:");
Console.WriteLine(jMin + 1);

int[,] finalMatrix = new int[m - 1, n - 1];
for (int i = 0; i < iMin; i++)
{
    for (int j = 0; j < jMin; j++)
    {
        finalMatrix[i, j] = matrix[i, j];
    }
}
for (int i = iMin; i < m - 1; i++)
{
    for (int j = 0; j < jMin; j++)
    {
        finalMatrix[i, j] = matrix[i + 1, j];
    }
}
for (int i = 0; i < iMin; i++)
{
    for (int j = jMin; j < n - 1; j++)
    {
        finalMatrix[i, j] = matrix[i, j + 1];
    }
}
for (int i = iMin; i < m - 1; i++)
{
    for (int j = jMin; j < n - 1; j++)
    {
        finalMatrix[i, j] = matrix[i + 1, j + 1];
    }
}

PrintMatrix(finalMatrix);