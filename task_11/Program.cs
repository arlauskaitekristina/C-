// Наишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.WriteLine("Эта программа выводит случайное трехзначное число и удаляет вторую цифру этого числа");

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int firstDigit = (num / 100) * 10;
int thirdDigit = (num % 10);

int result = firstDigit + thirdDigit;
Console.WriteLine(result);
