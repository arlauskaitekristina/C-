// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    return array;
}

int[] GetSumNegPosElem(int[] array)
{
    int SumNeg = 0;
    int SumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            SumNeg = SumNeg + array[i];
        }
        else
        {
            SumPos = SumPos + array[i];
        }
    }

    return new[] {SumNeg, SumPos};
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
int[] resArray = CreateArrayRndInt(12);
PrintArray(resArray);
int[] sumNegPosElem = GetSumNegPosElem(resArray);

Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumNegPosElem[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegPosElem[0]}");
