// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Эта программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");
Console.Write("Введите цифру: ");

int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) Console.WriteLine("Нет");
else if (day == 2) Console.WriteLine("Нет");
else if (day == 3) Console.WriteLine("Нет");
else if (day == 4) Console.WriteLine("Нет");
else if (day == 5) Console.WriteLine("Нет");
else if (day == 6) Console.WriteLine("Да");
else if (day == 7) Console.WriteLine("Да");
else Console.WriteLine("Это не цифра от 1 до 7");

