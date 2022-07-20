// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Эта программа задает двумерный массив размером m x n, заполненный случайными вещественными числами.");
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrixRndInt(int m, int n, int min=-100, int max=100)
{
    Random rnd = new Random();
    var array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return array;
}

void PrintMatrix(double[,] array, int m, int n, int round = 2)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(Math.Round(array[i, j], round) + "\t");
        }
        Console.WriteLine();
    }
}

double[,] array = CreateMatrixRndInt(m, n);
PrintMatrix(array, m, n);