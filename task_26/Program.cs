// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Эта программа принимает на вход число и выдаёт количество цифр в числе");
Console.Write("Введите число для подсчета: ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitsCount(int a)

{
    int digitsCounter = 0;
    while (a != 0)
    {
        a /= 10;
        digitsCounter++;
    }
    return digitsCounter;
}

int amountOfDigits = DigitsCount(num);
Console.Write($"Количество цифр в числе {num} - {amountOfDigits}");
