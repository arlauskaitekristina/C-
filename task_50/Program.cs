// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.WriteLine("Эта программа на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет");
Console.Write("Введите строку: ");
int m = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int n = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Исходный массив:");
int rows = 7;
int columns = 7;
int[,] array = new int[rows, columns];


int[,] CreateMatrixRndInt(int m, int n, int min=0, int max=100)
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

int [,] arrayResult = CreateMatrixRndInt (m, n);
PrintMatrix(arrayResult);

if (m >= array.GetLength(0) - 1 || n >= array.GetLength(1) - 1)
{
    Console.WriteLine("Нет такого элемента");
}
else 
{
    Console.WriteLine("Искомый элемент: " + array[m, n]);
}