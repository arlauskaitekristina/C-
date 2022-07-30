// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Эта программа задает 2 матрицы и перемножает их.");

int[,] CreateMatrixRndInt(int m, int n, int minRange = 0, int maxRange = 10)
{
    Random rnd = new Random();

    var matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] MyltiMatrix(int[,] matrix1, int[,] matrix2)
{
    int row1 = matrix1.GetLength(0);
    int row2 = matrix2.GetLength(0);
    int col1 = matrix1.GetLength(1);
    int col2 = matrix2.GetLength(1);

    int[,] sum = new int[row1, col2];
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            sum[i, j] = 0;
            for (int k = 0; k < row2; k++)
            {
                sum[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return sum;
}

int rows1 = 2;
int columns1 = 2;
int[,] matrix1 = CreateMatrixRndInt(rows1, columns1);
Console.WriteLine($"\nПервая сгенерированная матрица:");
PrintMatrix(matrix1);

int rows2 = 2;
int columns2 = 2;
int[,] matrix2 = CreateMatrixRndInt(rows2, columns2);
Console.WriteLine($"\nВторая сгенерированная матрица:");
PrintMatrix(matrix2);

if (columns1 == rows2)
{
    int[,] resultOfMultiplication = MyltiMatrix(matrix1, matrix2);
    Console.WriteLine("\nПроизведение первой и второй матриц:");
    PrintMatrix(resultOfMultiplication);
}
