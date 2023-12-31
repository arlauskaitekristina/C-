﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] ArrayInit(uint length, int minRange = 0, int maxRange = 100)
{
    Random rnd = new Random();
    double[] array = new double[length];

    for (int i = 0; i < length; i++)
        array[i] = (rnd.NextDouble() * (maxRange - minRange) + minRange); // например если от 0 до 2 то [0.00 1.99]

    return array;
}

void ArrayPrinter(double[] array, int round = 2)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], round));
        Console.Write(i == array.Length - 1 ? "]\n" : " ");
    }
}

Console.WriteLine("Эта программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("На сколько элементов задать массив?");
uint n = Convert.ToUInt32(Console.ReadLine());

double[] array = ArrayInit(n);   // диапазон задается вторым и третьим параметрами. это необязательные параметры, по умолчанию [0, 100)

int round = 3;   // до скольки знаков после запятой округлить
double result = Math.Round(array.Max() - array.Min(), round);

ArrayPrinter(array);  // округление - второй необязательный параметр. по дефолту 3 знака

Console.WriteLine($"max - min = {result}");