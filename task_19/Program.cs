// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Эта программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100000 == 0 && number / 10000 != 0)
{
    int CheckingNumber = number % 100 / 10 + number % 10 * 10;   

    if (number / 1000 == CheckingNumber) 
        Console.WriteLine("Да, это число - палиндром");
    else
        Console.WriteLine("Нет, это число - не палиндром");
}
else
{
    Console.WriteLine("Это не пятизначное число");
}