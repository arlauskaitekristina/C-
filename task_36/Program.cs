//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.\
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Эта программа задаёт одномерный массив, заполненный случайными числами, и находит сумму элементов, стоящих на нечётных позициях.");

Console.Write($"Введи количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int CreateNumRnd(int num, int min, int max)
{
    int[] CreateNumRnd = new int [num];
    int SumElem = 0;
    Console.Write($"Получившийся массив: ");

    for (int i = 0; i < CreateNumRnd.Length; i++)
    {
        CreateNumRnd[i] = new Random().Next(min, max);

        Console.Write(CreateNumRnd[i] + " ");

        if (i % 2 != 1)
        {
            SumElem = SumElem + CreateNumRnd[i];
        }
    }
    return SumElem;
}

int createNumRnd = CreateNumRnd (num, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {createNumRnd}");
