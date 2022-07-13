// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Эта программа задаёт массив заполненный случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве.");

int[] num = new int[4];

void CreateNumRnd(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void SearchNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int PrintArr(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1) count++;
    }
    return count;
}

CreateNumRnd(num, 100, 1000);
SearchNum(num);
Console.WriteLine();

int count = PrintArr(num);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");