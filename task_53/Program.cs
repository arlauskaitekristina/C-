// Задайте двумерный массив. Напишите программу,которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Эта программа меняет местами первую и последнюю строку массива.");
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
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
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");
            else Console.Write(array[i, j] + "]");
        }
        Console.WriteLine();
    }
}

void ChangeRow(int[,] array)
{
    int idx1 = 0;
    int idx2 = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int row = array[idx1, i];
        array[idx1, i] = array[idx2, i];
        array[idx2, i] = row;
    }
}

Console.WriteLine("Исходный массив: ");
int [,] array = CreateMatrixRndInt(row, col);
PrintMatrix(array);
ChangeRow(array);
Console.WriteLine();
PrintMatrix(array);
