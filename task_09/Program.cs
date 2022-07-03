// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа 
// 78 -> 8
// 12 -> 2
// 85 -> 8

// Console.WriteLine("Эта программа выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа");

// int rndNum = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

// int firstDigit = rndNum / 10;
// int secondDigit = rndNum % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {rndNum} => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {rndNum} => {secondDigit}");

// int maxDigit = 0
// if(firstDigit > secondDigit)maxDigit = 0;
// else maxDigit = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Если первая цифра больше, чем вторая цифра, тогда выводим первую цифру иначе выводим вторую цифру

Console.WriteLine("Эта программа выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа");

int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

int MaxDigit(int num)
{
    int firstDigit = rndNum / 10;
    int secondDigit = rndNum % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit = MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры одинаковые"; 
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");
