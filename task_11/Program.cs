// Наишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.WriteLine("Эта программа выводит случайное трехзначное число и удаляет вторую цифру этого числа");

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int firstDigit = (num / 100) * 10;
// int thirdDigit = (num % 10);

// int result = firstDigit + thirdDigit;
// Console.WriteLine(result);

Console.WriteLine("Эта программа выводит случайное трехзначное число и удаляет вторую цифру этого числа");

var rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число: {rndNum}");

int CutMid (int num)
{
int firstDig = num / 100 * 10;
int secondDig = num % 10;
return firstDig + secondDig;
}
int result = CutMid(rndNum);

Console.WriteLine($"Полученное двухзначное число(через метод): {result}");
