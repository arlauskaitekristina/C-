// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Эта программа задает трёхмерный массив из неповторяющихся двузначных чисел и построчно выводит его, добавляя индексы каждого элемента");

int row = 3;
int col = 3;
int num = 3;
int[,,] MatrixInit3D(int row, int col, int num, int min = 10, int max = 99)
{
    Random rnd = new Random();
    var matrix = new int[row, col, num];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    int num = matrix.GetLength(2);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < num; k++)
            {
                Console.Write(matrix[i, j, k] + $"({i}, {j}, {k})" + "\t");
            }
            Console.WriteLine();
        }
    }
}

    int[,,] matrix = MatrixInit3D(row, col, num);
    Console.WriteLine($"\nCгенерированная матрица {row}x{col}x{num}:");
    PrintMatrix3D(matrix);
