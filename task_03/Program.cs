﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Эта программа находит наибольшее из двух чисел\nВведите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Наибольшее число = " + (num_1 > num_2 ? num_1 : num_2));