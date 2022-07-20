// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Эта программа задает двумерный массив из целых чисел и находит среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Исходный массив:");
int row = 4;
int col = 5;
int[,] array = new int[row, col];

int[,] CreateMatrixRndInt(int row, int col, int min = 0, int max = 100)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintArrMatrix(int[,] array)
{

    double mean;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        mean = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            mean += array[j, i];
        }
        Console.Write(Math.Round(mean / array.GetLength(0), 1) + "\t");
    }
}

int[,] arrayResult = CreateMatrixRndInt(row, col);
PrintMatrix(arrayResult);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArrMatrix(array);

